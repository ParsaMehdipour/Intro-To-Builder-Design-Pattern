namespace DemoLibrary.ProductClasses;

/// <summary>
/// It makes sense to use the Builder pattern only when your products are
/// quite complex and require extensive configuration.
/// Unlike in other creational patterns, different concrete builders can
/// produce unrelated products. In other words, results of various builders
/// may not always follow the same interface. (PizzaRecipe is different than Pizza)
/// </summary>
public class PizzaRecipe
{
    public string Instructions { get; set; }

    public void DisplayRecipe()
    {
        Console.WriteLine(Instructions);
    }
}
