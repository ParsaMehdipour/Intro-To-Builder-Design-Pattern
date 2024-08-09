using DemoLibrary.Interfaces;
using DemoLibrary.ProductClasses;

namespace DemoLibrary.ConcreteBuilders;

/// <summary>
/// The Concrete Builder classes follow the Builder interface and provide
/// specific implementations of the building steps. Your program may have
/// several variations of Builders, implemented differently.
/// </summary>
public class PizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza = new Pizza();

    // A fresh builder instance should contain a blank product object, which
    // is used in further assembly.
    public PizzaBuilder()
    {
        Reset();
    }

    // All production steps work with the same product instance.
    public void Reset() => _pizza = new Pizza();
    public void SetName(string name) => _pizza.Name = name;
    public void SetCrust(string crust) => _pizza.Crust = crust;
    public void SetSauce(string sauce) => _pizza.Sauce = sauce;
    public void AddTopping(string topping) => _pizza.Toppings.Add(topping);
    public void SetCookingMethod(string method) => _pizza.CookingMethod = method;

    // Concrete Builders are supposed to provide their own methods for
    // retrieving results. That's because various types of builders may
    // create entirely different products that don't follow the same
    // interface. Therefore, such methods cannot be declared in the base
    // Builder interface (at least in a statically typed programming
    // language).
    //
    // Usually, after returning the end result to the client, a builder
    // instance is expected to be ready to start producing another product.
    // That's why it's a usual practice to call the reset method at the end
    // of the `GetProduct` method body. However, this behavior is not
    // mandatory, and you can make your builders wait for an explicit reset
    // call from the client code before disposing of the previous result.
    public Pizza GetProduct()
    {
        Pizza result = _pizza;
        Reset();
        return result;
    }
}
