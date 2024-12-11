namespace FactoryPattern;

public class GigaRig : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("I am the Giga Rig with a seemingly infinite amount of wheels." +
                          "\nThose small vehicles could not even comprehend the amount of wheels that I could possibly have as it would explode their little engine minds." +
                          "\nI am the ultimate Rig.\nI am the Giga Rig.");
    }
}