using System;

namespace ChainResponsibility.Middlewares
{
    class CheckWeakPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("123456"))
            {
                Console.WriteLine("Sua senha é fraca!");
                return true;
            }

            return CheckNext(email, password);
        }
    }
}
