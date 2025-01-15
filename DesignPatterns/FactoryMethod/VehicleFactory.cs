using DesignPatterns.Models;
using static DesignPatterns.Models.Vehicle;

namespace DesignPatterns.FactoryMethod
{
    public  abstract class VehicleFactory
    {
        public abstract Models.Vehicle CreateVehicle();
    }

}
