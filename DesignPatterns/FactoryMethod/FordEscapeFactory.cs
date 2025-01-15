using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethod
{
    public class FordEscapeFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new CarModelBuilder()
                .setBrand("Ford")        // Marca del vehículo
                .setModel("Escape")      // Modelo específico
                .setColor("Red")         // Color específico
                .setYear(2023)           // Año del modelo
                .Build();                // Construye la instancia
        }
    }
}
