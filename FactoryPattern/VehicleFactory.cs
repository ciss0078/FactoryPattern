using System;
using System.Collections.Generic;
using System.Text;


namespace FactoryPattern
{
    public static  class VehicleFactory
    {
        public static IVehicle GetVehicle(int tire)
        {
            switch (tire)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                default:
                    return new Motorcycle();
            }
            
            
        }
    }
}
