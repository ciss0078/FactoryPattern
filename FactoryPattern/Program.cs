using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires are on a vehicle");
            int tires = int.Parse(Console.ReadLine());

            //VehicleFactory factory = new VehicleFactory();
            IVehicle vehicle = VehicleFactory.GetVehicle(tires);



            vehicle.Drive();
            
                
            
        }
    }
}
