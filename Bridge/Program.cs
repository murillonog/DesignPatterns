using Bridge.Plataforms;
using Bridge.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            StartLive(new Youtube());
            StartLive(new Facebook());
            StartLive(new Twitch());
            StartLive(new Netflix());

            StartAdvancedLive(new Youtube());
            StartAdvancedLive(new Facebook());
            StartAdvancedLive(new Twitch());
            StartAdvancedLive(new Netflix());

            Console.ReadKey();
        }

        private static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");
            Live live = new Live(platform);
            live.Broadcasting();
            live.Result();
            Console.WriteLine();
        }

        private static void StartAdvancedLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde...");
            AdvancedLive live = new AdvancedLive(platform);
            live.Broadcasting();
            live.Result();
            live.Subtitle();
            live.Coments();
            live.Record();
            Console.WriteLine();
        }
    }
}
