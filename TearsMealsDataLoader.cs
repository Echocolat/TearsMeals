using Microsoft.VisualBasic;
using OneOf;
using OneOf.Types;
using System.Text.Json;

namespace TearsMeals;

public static class GlobalVariables
{
    public static RecipeData FailedRecipe { get; } = new()
    {
        ResultActorName = "Item_Cook_O_01",
        PictureBookNum = 145,
        CookFailure = true
    };
}

public class TearsMealsDataLoader
{
    public TearsMealsData? TearsMealsData { get; set; }

    public TearsMealsData LoadData()
    {
        if (TearsMealsData != null)
            return TearsMealsData;

        using FileStream fs = File.OpenRead(@"Data\TearsMealsData.json");
        return TearsMealsData = JsonSerializer.Deserialize<TearsMealsData>(fs) ?? new TearsMealsData();
    }

    public List<TearsMealsResult> ProcessExtract(TearsMealsData mealData, TearsMealsResult result)
    {
        List<TearsMealsResult> results = new();
        List<TearsMealsResult> tempResults = new();

        result.CriticalDetails = "No critical hit can happen if a Monster Extract is present";

        if (result.Effect != "None" && result.EffectTime > 0)
        {
            var worstTimeOutcome = result.Clone();
            worstTimeOutcome.EffectTime = 60;
            worstTimeOutcome.ExtractDetails += "Worst time outcome (33%), ";
            tempResults.Add(worstTimeOutcome);

            var middleTimeOutcome = result.Clone();
            middleTimeOutcome.EffectTime = 600;
            middleTimeOutcome.ExtractDetails += "Middle time outcome (33%), ";
            tempResults.Add(middleTimeOutcome);

            var bestTimeOutcome = result.Clone();
            bestTimeOutcome.EffectTime = 1800;
            bestTimeOutcome.ExtractDetails += "Best time outcome (33%), ";
            tempResults.Add(bestTimeOutcome);
        }
        else
        {
            tempResults.Add(result);
        }

        if ((result.HitPointRecover == 0 && result.Effect != "None") || result.Effect == "LifeMaxUp")
        {
            foreach (TearsMealsResult timeResult in tempResults)
            {
                var worstEffectOutcome = timeResult.Clone();
                worstEffectOutcome.EffectLevel = mealData.EffectData[result.Effect].MinLv;
                worstEffectOutcome.ExtractDetails += "Worst effect outcome (50%)";
                results.Add(worstEffectOutcome);

                var bestEffectOutcome = timeResult.Clone();
                bestEffectOutcome.EffectLevel += mealData.EffectData[result.Effect].SuperSuccessAddVolume;
                bestEffectOutcome.ExtractDetails += "Best effect outcome (50%)";
                results.Add(bestEffectOutcome);
            }
        }
        else if (result.HitPointRecover == 0 && result.Effect == "None")
        {
            foreach (TearsMealsResult timeResult in tempResults)
            {
                var bestHealthOutcome = timeResult.Clone();
                bestHealthOutcome.HitPointRecover += mealData.EffectData["LifeRecover"].SuperSuccessAddVolume;
                bestHealthOutcome.ExtractDetails += "Best health recovery outcome (100%)";
                results.Add(bestHealthOutcome);
            }
        }
        else if (result.Effect != "None")
        {
            foreach (TearsMealsResult timeResult in tempResults)
            {
                var worstEffectOutcome = timeResult.Clone();
                worstEffectOutcome.EffectLevel = mealData.EffectData[result.Effect].MinLv;
                worstEffectOutcome.ExtractDetails += "Worst effect outcome, Neutral health recovery outcome (25%)";
                results.Add(worstEffectOutcome);

                var bestEffectOutcome = timeResult.Clone();
                bestEffectOutcome.EffectLevel += mealData.EffectData[result.Effect].SuperSuccessAddVolume;
                bestEffectOutcome.ExtractDetails += "Best effect outcome, Neutral health recovery outcome (25%)";
                results.Add(bestEffectOutcome);

                var worstHealthOutcome = timeResult.Clone();
                worstHealthOutcome.HitPointRecover = mealData.EffectData["LifeRecover"].MinLv;
                worstHealthOutcome.ExtractDetails += "Neutral effect outcome, Worst health recovery outcome (25%)";
                results.Add(worstHealthOutcome);

                var bestHealthOutcome = timeResult.Clone();
                bestHealthOutcome.HitPointRecover += mealData.EffectData["LifeRecover"].SuperSuccessAddVolume;
                bestHealthOutcome.ExtractDetails += "Neutral effect outcome, Best health recovery outcome (25%)";
                results.Add(bestHealthOutcome);
            }
        }
        else
        {
            foreach (TearsMealsResult timeResult in tempResults)
            {
                var worstHealthOutcome = timeResult.Clone();
                worstHealthOutcome.HitPointRecover = mealData.EffectData["LifeRecover"].MinLv;
                worstHealthOutcome.ExtractDetails += "Worst health recovery outcome (50%)";
                results.Add(worstHealthOutcome);

                var bestHealthOutcome = timeResult.Clone();
                bestHealthOutcome.HitPointRecover += mealData.EffectData["LifeRecover"].SuperSuccessAddVolume;
                bestHealthOutcome.ExtractDetails += "Best health recovery outcome (50%)";
                results.Add(bestHealthOutcome);
            }
        }

        return results;
    }

    public List<TearsMealsResult> ProcessCritical(TearsMealsData mealData, TearsMealsResult result)
    {
        List<TearsMealsResult> results = new();
        TearsMealsResult tempResult = result.Clone();

        if (result.SuperSuccessRate < 100)
        {
            results.Add(result);
        }

        // Clamp effect level to at least 1.0
        tempResult.EffectLevel = MathF.Min(tempResult.EffectLevel, 1.0f);

        if (tempResult.Effect == "None")
        {
            var healthCritical = tempResult.Clone();
            healthCritical.HitPointRecover += mealData.EffectData["LifeRecover"].SuperSuccessAddVolume;
            healthCritical.CriticalDetails += "Health critical (100% if critical)";
            results.Add(healthCritical);
        }
        else if (tempResult.Effect == "LifeMaxUp")
        {
            var levelCritical = tempResult.Clone();
            levelCritical.EffectLevel += mealData.EffectData[levelCritical.Effect].SuperSuccessAddVolume;
            levelCritical.CriticalDetails += "Level critical (100% if critical)";
            results.Add(levelCritical);
        }
        else if (tempResult.Effect == "StaminaRecover" || tempResult.Effect == "ExStaminaMaxUp")
        {
            if (tempResult.EffectLevel >= mealData.EffectData[tempResult.Effect].MaxLv)
            {
                var healthCritical = tempResult.Clone();
                healthCritical.HitPointRecover += mealData.EffectData["LifeRecover"].SuperSuccessAddVolume;
                healthCritical.CriticalDetails += "Health critical (100% if critical)";
                results.Add(healthCritical);
            }
            else
            {
                var healthCritical = tempResult.Clone();
                healthCritical.HitPointRecover += mealData.EffectData["LifeRecover"].SuperSuccessAddVolume;
                healthCritical.CriticalDetails += "Health critical (50% if critical)";
                results.Add(healthCritical);

                var levelCritical = tempResult.Clone();
                levelCritical.EffectLevel += mealData.EffectData[levelCritical.Effect].SuperSuccessAddVolume;
                levelCritical.CriticalDetails += "Level critical (50% if critical)";
                results.Add(levelCritical);
            }
        }
        else if (tempResult.EffectLevel >= mealData.EffectData[tempResult.Effect].MaxLv)
        {
            if (tempResult.HitPointRecover >= mealData.EffectData["LifeRecover"].MaxLv)
            {
                var timeCritical = tempResult.Clone();
                timeCritical.EffectTime += mealData.SystemData.SuperSuccessAddEffectiveTime;
                timeCritical.CriticalDetails += "Time critical (100% if critical)";
                results.Add(timeCritical);
            }
            else
            {
                var healthCritical = tempResult.Clone();
                healthCritical.HitPointRecover += mealData.EffectData["LifeRecover"].SuperSuccessAddVolume;
                healthCritical.CriticalDetails += "Health critical (50% if critical)";
                results.Add(healthCritical);

                var timeCritical = tempResult.Clone();
                timeCritical.EffectTime += mealData.SystemData.SuperSuccessAddEffectiveTime;
                timeCritical.CriticalDetails += "Time critical (50% if critical)";
                results.Add(timeCritical);
            }
        }
        else if (tempResult.HitPointRecover >= mealData.EffectData["LifeRecover"].MaxLv)
        {
            var levelCritical = tempResult.Clone();
            levelCritical.EffectLevel += mealData.EffectData[levelCritical.Effect].SuperSuccessAddVolume;
            levelCritical.CriticalDetails += "Level critical (50% if critical)";
            results.Add(levelCritical);

            var timeCritical = tempResult.Clone();
            timeCritical.EffectTime += mealData.SystemData.SuperSuccessAddEffectiveTime;
            timeCritical.CriticalDetails += "Time critical (50% if critical)";
            results.Add(timeCritical);
        }
        else
        {
            var healthCritical = tempResult.Clone();
            healthCritical.HitPointRecover += mealData.EffectData["LifeRecover"].SuperSuccessAddVolume;
            healthCritical.CriticalDetails += "Health critical (33% if critical)";
            results.Add(healthCritical);

            var levelCritical = tempResult.Clone();
            levelCritical.EffectLevel += mealData.EffectData[levelCritical.Effect].SuperSuccessAddVolume;
            levelCritical.CriticalDetails += "Level critical (33% if critical)";
            results.Add(levelCritical);

            var timeCritical = tempResult.Clone();
            timeCritical.EffectTime += mealData.SystemData.SuperSuccessAddEffectiveTime;
            timeCritical.CriticalDetails += "Time critical (33% if critical)";
            results.Add(timeCritical);
        }

        return results;
    }

    public List<TearsMealsResult> TearsMealsCook(string[] materials)
    {
        // Loads the data contained in the data json
        TearsMealsData mealData = LoadData();

        // Initialize the result class
        List<TearsMealsResult> results = new();
        TearsMealsResult result = new()
        {
            SellingPrice = 2,
            HitPointRecover = (int)mealData.SystemData.SubtleLifeRecover
        };
        
        // Add material data for each material
        foreach (string materialActorName in materials)
        {
            MaterialDataEntry materialData = mealData.MaterialData[materialActorName];
            result.Materials[materialActorName] = materialData;
        }

        // Generates the list of unique (material, tag) couples
        HashSet<(string, string)> materialCookTagSet = [];

        foreach (string actorName in materials)
        {
            materialCookTagSet.Add((actorName, result.Materials[actorName].CookTag));
        }
        List<(string, string)> materialCookTagList = [.. materialCookTagSet];

        // Finds the correct recipe
        RecipeData foundRecipe = GlobalVariables.FailedRecipe;
        bool AllOk = false;

        if (materialCookTagList.Count == 1)
        {
            // Single unique material case
            foreach (RecipeData singleRecipe in mealData.SingleRecipeData)
            {
                List<(string, string)> cookTagListCopy = [.. materialCookTagList];
                string recipeComp = singleRecipe.Recipe;
                List<string> partsList = [.. recipeComp.Split(" or ")];
                foreach (string orPart in partsList)
                {
                    (string material, string tag) = cookTagListCopy[0];
                    if (orPart == material || orPart == tag)
                    {
                        foundRecipe = singleRecipe;
                        result.Recipe = foundRecipe;
                        AllOk = true;
                        break;
                    }
                }
                if (AllOk)
                {
                    break;
                }
            }
        }
        else
        {
            // Multiple unique materias case
            foreach (RecipeData recipe in mealData.RecipeData)
            {
                List<(string, string)> usedMaterials = [];
                string recipeComp = recipe.Recipe;
                List<string> andParts = [.. recipeComp.Split(" + ")];
                List<List<string>> partsList = [];
                foreach (string andPart in andParts)
                {
                    partsList.Add([.. andPart.Split(" or ")]);
                }

                AllOk = true;
                foreach (List<string> andPart in partsList)
                {
                    bool AndOk = false;
                    foreach (string orPart in andPart)
                    {
                        foreach ((string, string) materialNameTag in materialCookTagList)
                        {
                            (string material, string tag) = materialNameTag;
                            if ((orPart == material || orPart == tag) && !usedMaterials.Contains(materialNameTag))
                            {
                                AndOk = true;
                                usedMaterials.Add(materialNameTag);
                                break;
                            }
                        }

                        if (AndOk)
                        {
                            break;
                        }
                    }

                    if (!AndOk)
                    {
                        AllOk = false;
                        break;
                    }

                }
                if (AllOk)
                {
                    foundRecipe = recipe;
                    result.Recipe = foundRecipe;
                    break;
                }
            }
        }

        // If at least two unique materials & one CookSpice, go through SingleRecipes
        var uniqueMaterialTags = new HashSet<string>(materialCookTagList.Select(tag => tag.Item2));
        if (materialCookTagList.Any(tag => tag.Item2 == "CookSpice") && uniqueMaterialTags.Count >= 2 && !AllOk)
        {
            foreach (RecipeData singleRecipe in mealData.SingleRecipeData)
            {
                List<(string, string)> materialsNameTagCopy = new List<(string, string)>(materialCookTagList);
                string recipeComp = singleRecipe.Recipe;
                List<string> partsList = recipeComp.Split(" or ").ToList();
                foreach (string orPart in partsList)
                {
                    (string material, string tag) materialNameTag = materialsNameTagCopy[0];
                    if (orPart == materialNameTag.material)
                    {
                        foundRecipe = singleRecipe;
                        result.Recipe = foundRecipe;
                        AllOk = true;
                        break;
                    }
                }
                if (AllOk)
                {
                    break;
                }
            }
        }

        // Setting and returning data for failed meals
        if (foundRecipe.CookFailure)
        {
            if (foundRecipe.ResultActorName == mealData.SystemData.FailActorName)
            {
                result.HitPointRecover = (int)mealData.SystemData.SubtleLifeRecover;
            }
            else
            {
                result.HitPointRecover = (int)mealData.SystemData.FailLifeRecover;
            }

            result.Effect = "None";
            result.EffectLevel = 0;
            result.EffectTime = 0;
            result.SellingPrice = 0;
            result.SuperSuccessRate = 0;

            results.Add(result);
            return results;
        }

        // Setting effect, effect level and effect duration
        bool setEffect = false;
        float effectLevel = 0.0f;
        string effectType = "None";
        int effectTime = 0;
        int bonusTime = 0;
        int bonusMaxHeart = 0;   // unused in game
        int bonusStamina = 0;    // unused in game

        // CookEnemy Spice happens before Monster Extract and Criticals
        foreach (string actorName in materials)
        {
            if (result.Materials[actorName].CookTag == "CookEnemy")
            {
                bonusTime += result.Materials[actorName]?.SpiceBoostEffectiveTime ?? 0;
                bonusMaxHeart += result.Materials[actorName]?.SpiceBoostMaxHeartLevel ?? 0;   // unused in game
                bonusStamina += result.Materials[actorName]?.SpiceBoostStaminaLevel ?? 0;     // unused in game
            }
        }

        // Cycle through each effect
        foreach ((string effectName, EffectDataEntry effect) in mealData.EffectData)
        {
            int effectMaterialsNum = materials
                .Where(actorName => result.Materials.TryGetValue(actorName, out var mat)
                                    && (mat?.CureEffectType ?? "None") == effectName)
                .Count();
            if (effectMaterialsNum > 0)
            {
                // setEffect is there to prevent a meal from having multiple effects, if that happens, its effect variables are reset
                if (setEffect)
                {
                    effectType = "None";
                    break;
                }

                effectType = effectName;
                int potencySum = 0;
                effectTime += bonusTime;
                foreach (string actorName in materials)
                {
                    if ((result.Materials[actorName]?.CureEffectType ?? "None") == effectName)
                    {
                        potencySum += result.Materials[actorName]?.CureEffectLevel ?? 0;
                    }
                    effectTime += 30;
                }

                effectTime += materials.Length * effect?.BaseTime ?? 0;
                effectLevel += (effect?.Rate ?? 0) * potencySum;

                // unused in game. Logic is in the game's code, but no material has those properties
                // (SpiceBoostMaxHeartLevel and SpiceBoostStaminaLevel)
                 if (effectType == "LifeMaxUp")
                 {
                     effectLevel += bonusMaxHeart;
                 }
                 else if (effectType == "StaminaRecovery" || effectType == "ExStaminaUp")
                 {
                     effectLevel += bonusStamina;
                 }

                effectLevel = MathF.Min(effectLevel, effect.MaxLv);
                setEffect = true;
            }
        }

        // Effect-less elixir is invalid (though impossible to reach in vanilla game)
        // Same for multi-effect elixirs, which generate a failed meal
        if ((result.Recipe?.CookEMedicine ?? false) && effectType == "None")
        {
            result.Recipe = GlobalVariables.FailedRecipe;
        }

        // Hardcoded values for Fairy Tonic and failed meal
        var hardcodedExceptions = new HashSet<string>
        {
            mealData.SystemData.FairyActorName,
            mealData.SystemData.FailActorName,
            "Item_Cook_O_02"
        };
        if (hardcodedExceptions.Contains(result.Recipe.ResultActorName))
        {
            effectType = "None";
            effectLevel = 0.0f;
            effectTime = 0;
        }

        var hardcodedEffectTime = new HashSet<string>
        {
            "LifeMaxUp",
            "StaminaRecover",
            "ExStaminaMaxUp",
            "LifeRepair"
        };
        if (hardcodedEffectTime.Contains(effectType))
        {
            effectTime = 0;
        }

        result.Effect = effectType;
        result.EffectLevel = effectLevel;
        result.EffectTime = effectTime;

        // Setting health recovery
        int hitPointRecover = 0;
        float lifeRecoverRate;

        foreach (string actorName in materials)
        {
            hitPointRecover += result.Materials[actorName]?.HitPointRecover ?? 0;
        }

        if (result.Recipe.ResultActorName == mealData.SystemData.FailActorName || result.Recipe.ResultActorName == "Item_Cook_O_02")
        {
            lifeRecoverRate = mealData.SystemData.SubtleLifeRecoverRate;
        }
        else
        {
            lifeRecoverRate = mealData.SystemData.LifeRecoverRate;
        }

        hitPointRecover *= (int)lifeRecoverRate;
        result.HitPointRecover = hitPointRecover;

        // Setting crit chances
        int superSuccessRate = 0;

        foreach (string actorName in materials)
        {
            superSuccessRate = Math.Max(superSuccessRate, result.Materials[actorName]?.SpiceBoostSuccessRate ?? 0);
        }

        foreach (SuperSuccessRateListEntry item in mealData.SystemData.SuperSuccessRateList)
        {
            if (item.MaterialTypeNum == materialCookTagList.Count)
            {
                superSuccessRate += (int)Math.Round(item.Rate);
                break;
            }
        }

        result.SuperSuccessRate = superSuccessRate;
        bool hasExtract = false;

        // Setting selling price
        int sellingPrice = 0;
        foreach (string actorName in materials)
        {
            if (result.Materials[actorName]?.CookLowPrice ?? false)
            {
                sellingPrice++;
            }
            else
            {
                sellingPrice += result.Materials[actorName]?.SellingPrice ?? 0;
            }
        }

        foreach (PriceRateListEntry item in mealData.SystemData.PriceRateList)
        {
            if (item.MaterialNum == materials.Length)
            {
                sellingPrice = (int)Math.Floor(sellingPrice * item.Rate);
            }
        }

        sellingPrice = Math.Max(sellingPrice, 3);
        if (hardcodedExceptions.Contains(result.Recipe.ResultActorName))
        {
            sellingPrice = 2;
        }

        result.SellingPrice = sellingPrice;

        // Setting all possible combinations of Monster Extract effects, if there's a Monster Extract
        if (materials.Contains(mealData.SystemData.EnemyExtractActorName))
        {
            results = ProcessExtract(mealData, result);
            hasExtract = true;
        }

        // Setting all possible combinations of Critical Hit effects, if there's no Monster Extract
        if (!hasExtract)
        {
            results = ProcessCritical(mealData, result);
        }

        // Setting eventual SpiceBoost
        foreach (TearsMealsResult spiceResult in results)
        {
            foreach ((string, string) materialNameTag in materialCookTagList)
            {
                string actorName = materialNameTag.Item1;
                string cookTag = materialNameTag.Item2;
                if (cookTag != "CookEnemy")
                {
                    spiceResult.HitPointRecover += mealData.MaterialData[actorName]?.SpiceBoostHitPointRecover ?? 0;
                    if (spiceResult.EffectTime > 0)
                    {
                        spiceResult.EffectTime += mealData.MaterialData[actorName]?.SpiceBoostEffectiveTime ?? 0;
                    }
                }
                // unused in game. Logic is in the game's code, but no material has those properties
                // (SpiceBoostMaxHeartLevel and SpiceBoostStaminaLevel)
                if (cookTag == "CookSpice")
                {
                    if (spiceResult.Effect == "LifeMaxUp")
                    {
                        spiceResult.EffectLevel += mealData.MaterialData[actorName]?.SpiceBoostMaxHeartLevel ?? 0;
                    }
                    else if (spiceResult.Effect == "StaminaRecover" || spiceResult.Effect == "ExStaminaMaxUp")
                    {
                        spiceResult.EffectLevel += mealData.MaterialData[actorName]?.SpiceBoostStaminaLevel ?? 0;
                    }
                }
            }
        }

        // Setting meal bonus, and final clamping of health, effect level and effect time
        foreach (TearsMealsResult bonusResult in results)
        {
            if (bonusResult.Effect == "LifeMaxUp")
            {
                bonusResult.HitPointRecover = mealData.EffectData["LifeRecover"].MaxLv;
            }
            else
            {
                bonusResult.HitPointRecover = Math.Min(120, bonusResult.HitPointRecover + bonusResult.Recipe?.BonusHeart ?? 0);
                if (bonusResult.HitPointRecover == 120)
                {
                    bonusResult.HitPointRecover = mealData.EffectData["LifeRecover"].MaxLv;
                }
                if (bonusResult.Effect == "None" && bonusResult.HitPointRecover == 0)
                {
                    bonusResult.HitPointRecover = 1;
                }
            }
            if (bonusResult.Effect != "None")
            {
                bonusResult.EffectLevel = Math.Min(bonusResult.EffectLevel, mealData.EffectData[bonusResult.Effect].MaxLv);
                if (bonusResult.EffectLevel <= 1.0f && bonusResult.EffectLevel > 0.0f)
                {
                    bonusResult.EffectLevel = 1.0f;
                }
                if (bonusResult.Effect == "LifeMaxUp" || bonusResult.Effect == "LifeRepair")
                {
                    bonusResult.EffectLevel = 4 * (float)Math.Round(bonusResult.EffectLevel / 4.0f);
                    bonusResult.EffectLevel = (bonusResult.EffectLevel <= 4.0f && bonusResult.EffectLevel > 0.0f)
                        ? 4.0f
                        : bonusResult.EffectLevel;
                }
                bonusResult.EffectLevel = (float)Math.Floor(bonusResult.EffectLevel);
                if (bonusResult.EffectTime > 0)
                {
                    bonusResult.EffectTime = Math.Min(1800, bonusResult.EffectTime + bonusResult.Recipe?.BonusTime ?? 0);
                }
            }
        }

        return results;
    }
}