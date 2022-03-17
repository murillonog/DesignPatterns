using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void CreatePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebenndo pagamento pagamento do Mercado Pago!");
        }

        public void GetPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento pagamento do Mercado Pago!");
        }
    }
}
