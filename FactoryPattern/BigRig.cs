namespace FactoryPattern;

public class BigRig : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("I am a Big Rig and I have at least 5 wheels!\nI am a cut above the rest of those small puny vehicles!");
    }
}