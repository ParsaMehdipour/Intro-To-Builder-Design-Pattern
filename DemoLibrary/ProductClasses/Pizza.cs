namespace DemoLibrary.ProductClasses;

/// <summary>
/// It makes sense to use the Builder pattern only when your products are
/// quite complex and require extensive configuration.
/// Unlike in other creational patterns, different concrete builders can
/// produce unrelated products. In other words, results of various builders
/// may not always follow the same interface. (Pizza is different than PizzaRecipe)
/// </summary>
public class Pizza
{
    public string Name { get; set; }
    public string Crust { get; set; }
    public string Sauce { get; set; }
    public List<string> Toppings { get; set; } = new List<string>();
    public string CookingMethod { get; set; }

    public void Display()
    {
        Console.WriteLine($"Pizza: {Name}");
        Console.WriteLine($"Crust: {Crust}");
        Console.WriteLine($"Sauce: {Sauce}");
        Console.WriteLine($"Toppings: {string.Join(", ", Toppings)}");
        Console.WriteLine($"Cooking Method: {CookingMethod}");
    }
}
