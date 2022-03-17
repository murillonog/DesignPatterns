using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedaCar();

            Vehicle sedan = builder.GetVehicle();
            Console.WriteLine($"Criado um veiculo do tipo: {sedan.VehicleType}");

            director.ConstructTruck();

            Vehicle truck = builder.GetVehicle();
            Console.WriteLine($"Criado um veiculo do tipo: {truck.VehicleType}");

            director.ConstructSUV();
            Vehicle suv = builder.GetVehicle();
            Console.WriteLine($"Criado um veiculo do tipo: {suv.VehicleType} e {suv.Airbag.Existe} airbags");
            Console.ReadKey();
        }
    }
}
