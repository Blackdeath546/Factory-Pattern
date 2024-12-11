namespace FactoryPattern;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("I am a cool car and I drive with 4 wheels!\nGnarly dude!");
    }
}