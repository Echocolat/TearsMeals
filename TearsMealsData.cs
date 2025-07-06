#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace TearsMeals;

public class TearsMealsData
{
    public SystemData SystemData { get; set; }

    public Dictionary<string, EffectDataEntry> EffectData { get; set; }

    public Dictionary<string, MaterialDataEntry> MaterialData { get; set; }

    public Dictionary<string, string> LocaleData { get; set; }

    public RecipeData[] RecipeData { get; set; }

    public RecipeData[] SingleRecipeData { get; set; }

    public string[] RecipeCardData { get; set; }
}

public class SystemData
{
    public string EnemyExtractActorName { get; set; }

    public string FailActorName { get; set; }

    public int FailLifeRecover { get; set; }

    public string FairyActorName { get; set; }

    public float LifeRecoverRate { get; set; }

    public PriceRateListEntry[] PriceRateList { get; set; }

    public float SubtleLifeRecover { get; set; }

    public float SubtleLifeRecoverRate { get; set; }

    public int SuperSuccessAddEffectiveTime { get; set; }

    public SuperSuccessRateListEntry[] SuperSuccessRateList { get; set; }
}

public class PriceRateListEntry
{
    public int MaterialNum { get; set; }

    public float Rate { get; set; }
}

public class SuperSuccessRateListEntry
{
    public int MaterialTypeNum { get; set; }

    public float Rate { get; set; }
}

public class EffectDataEntry
{
    public int BaseTime { get; set; }

    public int MinLv { get; set; }

    public int MaxLv { get; set; }

    public int SuperSuccessAddVolume { get; set; }

    public float Rate { get; set; }

    public int Priority { get; set; }
}

public class MaterialDataEntry
{
    public int PictureBookNum { get; set; }

    public string CookTag { get; set; }

    public int HitPointRecover { get; set; }

    public string CureEffectType { get; set; }

    public int CureEffectLevel { get; set; }

    public int CureEffectiveTime { get; set; }

    public int BuyingPrice { get; set; }

    public int SellingPrice { get; set; }

    public int PouchSortKey { get; set; }

    public int SpiceBoostEffectiveTime { get; set; }

    public int SpiceBoostMaxHeartLevel { get; set; }

    public int SpiceBoostStaminaLevel { get; set; }

    public int SpiceBoostSuccessRate { get; set; }

    public int SpiceBoostHitPointRecover { get; set; }

    public bool CookLowPrice { get; set; }

    public MaterialDataEntry Clone()
    {
        return new MaterialDataEntry
        {
            PictureBookNum = this.PictureBookNum,
            CookTag = this.CookTag,
            HitPointRecover = this.HitPointRecover,
            CureEffectType = this.CureEffectType,
            CureEffectLevel = this.CureEffectLevel,
            CureEffectiveTime = this.CureEffectiveTime,
            BuyingPrice = this.BuyingPrice,
            SellingPrice = this.SellingPrice,
            PouchSortKey = this.PouchSortKey,
            SpiceBoostEffectiveTime = this.SpiceBoostEffectiveTime,
            SpiceBoostMaxHeartLevel = this.SpiceBoostMaxHeartLevel,
            SpiceBoostStaminaLevel = this.SpiceBoostStaminaLevel,
            SpiceBoostSuccessRate = this.SpiceBoostSuccessRate,
            SpiceBoostHitPointRecover = this.SpiceBoostHitPointRecover,
            CookLowPrice = this.CookLowPrice
        };
    }
}

public class RecipeData
{
    public string ResultActorName { get; set; }

    public string Recipe { get; set; }

    public int PictureBookNum { get; set; }

    public int BonusHeart { get; set; }

    public int BonusTime { get; set; }

    public bool IsSingleRecipe { get; set; }

    public bool CookFailure { get; set; }

    public bool CookEMedicine { get; set; }

    public RecipeData Clone()
    {
        return new RecipeData
        {
            ResultActorName = this.ResultActorName,
            Recipe = this.Recipe,
            PictureBookNum = this.PictureBookNum,
            BonusHeart = this.BonusHeart,
            BonusTime = this.BonusTime,
            IsSingleRecipe = this.IsSingleRecipe,
            CookFailure = this.CookFailure,
            CookEMedicine = this.CookEMedicine
        };
    }
}