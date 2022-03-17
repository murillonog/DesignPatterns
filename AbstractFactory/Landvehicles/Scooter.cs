using System;

namespace AbstractFactory.Landvehicles
{
    class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("O entregador acabou de pegar sua encomenda.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Seu pedido está a caminho!");
        }
    }
}
