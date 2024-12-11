namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(int wheelAmount)
    {
        switch (wheelAmount)
        {
            case < 0:
                return new UFO();
            case 0:
                return new UFO();
            case 1:
                return new Unicycle();
            case 2:
            case 3:
                return new Motorcycle();
            case 4:
                return new Car();
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
                return new BigRig();
            case > 19:
                return new GigaRig();
            default:
                return null;
        }
    }
}