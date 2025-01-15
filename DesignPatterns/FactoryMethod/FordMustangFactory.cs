using DesignPatterns.Models;
using DesignPatterns.ModelBuilders;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns.ModelBuilders
{
    public class FordMustangFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new CarModelBuilder()
                .setBrand("Ford")
                .setModel("Mustang")
                .setColor("Red")
                .setYear(2023)
                .Build();
        }
    }
}
