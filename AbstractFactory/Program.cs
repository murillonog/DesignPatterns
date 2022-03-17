using AbstractFactory.App;
using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;
            string company = "lime";

            if (company == "uber")
            {
                transportFactory = new UberTransport();
            }
            else if (company == "99")
            {
                transportFactory = new NineNineTransport();
            }else
            {
                transportFactory = new LimeTransport();
            }

            app = new Application(transportFactory);

            return app;
        }
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();
            app.StartRoute();
            Console.ReadKey();
        }
    }
}
