namespace FactoryPattern;

public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("I am a Motorcycle and I drive with 2-3 wheels!\nIsn't that crazy!?");
    }
}