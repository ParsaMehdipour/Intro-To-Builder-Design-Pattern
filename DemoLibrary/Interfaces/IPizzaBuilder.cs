namespace DemoLibrary.Interfaces;

/// <summary>
/// The Builder interface specifies methods for creating the different parts
/// of the Product objects.
/// </summary>
public interface IPizzaBuilder
{
    void Reset();
    void SetName(string name);
    void SetCrust(string crust);
    void SetSauce(string sauce);
    void AddTopping(string topping);
    void SetCookingMethod(string method);
}
