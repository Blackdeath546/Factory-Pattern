namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var wheelAmount = Console.ReadLine();
            Console.WriteLine("Please enter the number of wheels your dream vehicle has:\n");

            while (true)
            {
                
                var wheelInput = Console.ReadLine();

                if (int.TryParse(wheelInput, out int wheelAmount))
                {
                    var vehicle = VehicleFactory.GetVehicle(wheelAmount);

                    vehicle.Drive();
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid input!\n Try again!");
                }

            }

        }
    }
}
