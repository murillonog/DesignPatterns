using System;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, ventos ok");
        }

        public void GetCargo()
        {
            Console.WriteLine("O drone está com sua encomenda.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Seu pedido chegará em instantes!");
        }
    }
}
