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
    public string CriticalDetails { get; set; } = "";
    public string ExtractDetails { get; set; } = "";
    public TearsMealsResult Clone()
    {
        var clone = new TearsMealsResult
        {
            Recipe = this.Recipe?.Clone(), 
            Effect = this.Effect,
            EffectLevel = this.EffectLevel,
            EffectTime = this.EffectTime,
            SellingPrice = this.SellingPrice,
            HitPointRecover = this.HitPointRecover,
            SuperSuccessRate = this.SuperSuccessRate,
            CriticalDetails = this.CriticalDetails,
            ExtractDetails = this.ExtractDetails
        };

        foreach (var kvp in this.Materials)
        {
            clone.Materials[kvp.Key] = kvp.Value.Clone();
        }

        return clone;
    }
}
