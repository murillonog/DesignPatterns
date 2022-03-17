using System;

namespace Bridge.Plataforms
{
    class Netflix : IPlatform
    {
        public Netflix()
        {
            ConfigureRMTP();
            Console.WriteLine("Netflix: transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Netflix: autorizando a aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Netflix: configurando servidor RMTP.");
        }
    }
}
