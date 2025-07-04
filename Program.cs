#pragma warning disable

using Newtonsoft.Json;
using TearsMeals;

class EmptyMaterialListException(string message) : Exception(message)
{
}

class InvalidMaterialException(string message) : Exception(message)
{
}

class TooMuchMaterialException(string message) : Exception(message)
{
}

namespace TearsMeals
{
    public class TearsMealsResult
    {
        public Recipedata recipe { get; set; } = new();
        public string effect { get; set; } = "";
        public int effectLevel { get; set; }
        public int effectTime { get; set; }
        public int sellingPrice { get; set; }
        public int hitPointRecover { get; set; }
        public int superSuccessRate { get; set; }
        public List<object> materials { get; set; } = new();
    }

    public class TearsMealsDataLoader
    {
        public TearsMealsData tearsMealsData { get; set; }

        public void TearsMealsDataLoad()
        {
            if (tearsMealsData != null)
                return;

            string json = File.ReadAllText(@"Data\TearsMealsData.json");
            tearsMealsData = JsonConvert.DeserializeObject<TearsMealsData>(json);
        }

        public TearsMealsResult TearsMealsCook(List<string> materials)
        {
            // Loads the data contained in the data json
            TearsMealsDataLoad();

            // Iinitialize the result class
            TearsMealsResult result = new TearsMealsResult();
            result.sellingPrice = 2;
            result.hitPointRecover = (int)tearsMealsData.SystemData.SubtleLifeRecover;

            // Generates a list of material dictionaries
            var materialData = tearsMealsData.MaterialData;
            var type = typeof(Materialdata);
            var props = materials.Select(name => type.GetProperty(name)).ToList();
            foreach (var prop in props)
            {
                var value = prop.GetValue(materialData);
                result.materials.Add(value);
            }

            // Finds the recipe
            List<(string, string)> materialsNameTag = new List<(string, string)>();
            string actorName;
            string cookTag;

            foreach (var material in result.materials)
            {
                var cookTagProp = material.GetType().GetProperty("CookTag");
                cookTag = cookTagProp?.GetValue(material)?.ToString();
                actorName = material.GetType().Name;
                materialsNameTag.Add((actorName, cookTag));
            }

            return result;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        TearsMealsDataLoader loader = new TearsMealsDataLoader();
        Recipedata failureRecipe = new Recipedata();

        var tearsMealsData = loader.tearsMealsData;
        failureRecipe.ResultActorName = "Item_Cook_O_01";
        failureRecipe.PictureBookNum = 145;
        failureRecipe.CookFailure = true;

        TearsMealsResult finalResult = new TearsMealsResult();
        List<string> materials = new List<string>();
        if (args.Length == 0)
        {
            Console.WriteLine("Enter ingredient actor names (space-separated):");
            materials = Console.ReadLine().Split(' ').ToList();
        }
        else
        {
            materials = args.ToList();
        }
        finalResult = loader.TearsMealsCook(materials);
    }
}
