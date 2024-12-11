namespace FactoryPattern;

public class UFO : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("I am a UFO and I do not require any wheels as I am the ultimate Vehicle!");
    }
}