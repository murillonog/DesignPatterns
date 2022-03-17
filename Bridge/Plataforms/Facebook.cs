using System;

namespace Bridge.Plataforms
{
    class Facebook : IPlatform
    {
        public Facebook()
        {
            ConfigureRMTP();
            Console.WriteLine("Facebook: transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Facebook: autorizando a aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: configurando servidor RMTP.");
        }
    }
}
