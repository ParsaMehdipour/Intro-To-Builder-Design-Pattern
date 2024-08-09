using DemoLibrary;
using DemoLibrary.ConcreteBuilders;
using DemoLibrary.ProductClasses;

PizzaDirector director = new PizzaDirector();

PizzaBuilder pizzaBuilder = new PizzaBuilder();
PizzaRecipeBuilder recipeBuilder = new PizzaRecipeBuilder();

// Create Margherita pizza
director.CreateMargherita(pizzaBuilder);
Pizza margherita = pizzaBuilder.GetProduct();

director.CreateMargherita(recipeBuilder);
PizzaRecipe margheritaRecipe = recipeBuilder.GetProduct();

margherita.Display();
Console.WriteLine();
margheritaRecipe.DisplayRecipe();

Console.WriteLine("\n" + new string('-', 50) + "\n");

// Create Pepperoni pizza
director.CreatePepperoni(pizzaBuilder);
Pizza pepperoni = pizzaBuilder.GetProduct();

director.CreatePepperoni(recipeBuilder);
PizzaRecipe pepperoniRecipe = recipeBuilder.GetProduct();

pepperoni.Display();
Console.WriteLine();
pepperoniRecipe.DisplayRecipe();