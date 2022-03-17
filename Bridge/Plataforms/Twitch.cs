using System;

namespace Bridge.Plataforms
{
    class Twitch : IPlatform
    {
        public Twitch()
        {
            ConfigureRMTP();
            Console.WriteLine("Twitch: transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Twitch: autorizando a aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Twitch: configurando servidor RMTP.");
        }
    }
}
