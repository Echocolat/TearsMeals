using TearsMeals;

TearsMealsDataLoader loader = new();
TearsMealsData? tearsMealsData = loader.TearsMealsData;

string[] materials;

if (args.Length == 0)
{
    Console.WriteLine("Enter ingredient actor names (space-separated):");
    materials = Console.ReadLine()?.Split(' ') ?? [];
}
else
{
    materials = args;
}

TearsMealsResult finalResult = loader.TearsMealsCook(materials);