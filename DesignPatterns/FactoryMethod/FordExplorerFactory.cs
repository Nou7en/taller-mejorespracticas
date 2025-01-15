using DesignPatterns.Models;
using DesignPatterns.ModelBuilders;
using DesignPatterns.FactoryMethod;

namespace DesignPatterns.ModelBuilders
{
    public class FordExplorerFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new CarModelBuilder()
                .setBrand("Ford")
                .setModel("Explorer")
                .setColor("Blue")
                .setYear(2022)
                .Build();
        }
    }
}
