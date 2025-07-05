namespace TearsMeals;

public class TearsMealsResult
{
    public RecipeData Recipe { get; set; } = new();

    public string Effect { get; set; } = "";

    public int EffectLevel { get; set; }

    public int EffectTime { get; set; }

    public int SellingPrice { get; set; }

    public int HitPointRecover { get; set; }

    public int SuperSuccessRate { get; set; }

    public Dictionary<string, MaterialDataEntry> Materials { get; } = [];
}