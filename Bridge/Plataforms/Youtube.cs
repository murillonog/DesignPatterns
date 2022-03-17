using System;

namespace Bridge.Plataforms
{
    class Youtube : IPlatform
    {
        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: autorizando a aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: configurando servidor RMTP.");
        }
    }
}
