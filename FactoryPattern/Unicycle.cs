namespace FactoryPattern;

public class Unicycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("I am a unicycle and I use one wheel!\nI am FAR from basic!");
    }
}