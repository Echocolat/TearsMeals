using System.Text.Json;

namespace TearsMeals;

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

    public TearsMealsResult TearsMealsCook(string[] materials)
    {
        // Loads the data contained in the data json
        TearsMealsData mealData = LoadData();

        // Initialize the result class
        TearsMealsResult result = new() {
            SellingPrice = 2,
            HitPointRecover = (int)mealData.SystemData.SubtleLifeRecover
        };

        foreach (string materialActorName in materials)
        {
            if (!mealData.MaterialData.TryGetValue(materialActorName, out MaterialDataEntry? materialData))
            {
                Console.WriteLine($"The material '{materialActorName}' could not be found.");
                continue;
            }
            
            result.Materials[materialActorName] = materialData;
        }

        // Never used?
        List<(string, string)> cookTags = [];

        foreach ((string actorName, MaterialDataEntry material) in result.Materials)
        {
            cookTags.Add((actorName, material.CookTag));
        }

        return result;
    }
}