using System;

namespace FactoryMethod.Vehicles
{
    class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando seu pedido");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Seu pedido saiu para entrega");
        }
    }
}
