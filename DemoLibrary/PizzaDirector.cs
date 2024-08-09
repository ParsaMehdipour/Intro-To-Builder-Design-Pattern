// Ignore Spelling: Margherita

using DemoLibrary.Interfaces;

namespace DemoLibrary;

// The Director is only responsible for executing the building steps in a
// particular sequence. It is helpful when producing products according to a
// specific order or configuration. Strictly speaking, the Director class is
// optional, since the client can control builders directly.
public class PizzaDirector
{
    public void CreateMargherita(IPizzaBuilder builder)
    {
        builder.Reset();
        builder.SetName("Margherita");
        builder.SetCrust("Thin");
        builder.SetSauce("Tomato");
        builder.AddTopping("Fresh Mozzarella");
        builder.AddTopping("Fresh Basil");
        builder.SetCookingMethod("Wood-fired oven");
    }

    public void CreatePepperoni(IPizzaBuilder builder)
    {
        builder.Reset();
        builder.SetName("Pepperoni");
        builder.SetCrust("Regular");
        builder.SetSauce("Tomato");
        builder.AddTopping("Mozzarella");
        builder.AddTopping("Pepperoni");
        builder.SetCookingMethod("Electric oven");
    }
}
