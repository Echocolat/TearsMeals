namespace TearsMeals;

public class TearsMealsResult
{
    public IRecipe Recipe { get; set; }

    public string Effect { get; set; } = "None";

    public float EffectLevel { get; set; }

    public int EffectTime { get; set; }

    public int SellingPrice { get; set; }

    public int HitPointRecover { get; set; }

    public int SuperSuccessRate { get; set; }

    public Dictionary<string, MaterialDataEntry> Materials { get; } = [];
}