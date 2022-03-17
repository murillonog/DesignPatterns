using ChainResponsibility.Middlewares;
using ChainResponsibility.Servers;
using System;

namespace ChainResponsibility
{
    static class Program
    {
        private static Server server;
        static void Main(string[] args)
        {
            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite o seu e-mail:");

                string email = Console.ReadLine();

                Console.WriteLine("Digite a sua senha:");

                string password = Console.ReadLine();

                done = server.LogIn(email, password);

            }while (!done);

            Console.ReadKey();
        }

        static void Init()
        {
            server = new Server();
            server.RegisterUser("master@hcode.com.br", "123uigbiufs");
            server.RegisterUser("user@hcode.com.br", "123456");

            Middleware middleware = new CheckUserMiddleware(server);
            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckWeakPasswordMiddleware());

            server.SetMiddleware(middleware);

        }
    }
}
