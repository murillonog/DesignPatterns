using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PayPal payment = new PayPal();

            IPayPalPayment payment = new PayonnerAdapter(new Payonner()); 
            payment.PayPalPayment();
            payment.PayPalReceive();

            //Payonner payment = new Payonner();

            //payment.SendPayment();
            //payment.ReceivePayment();

            IPayPalPayment newpayment = new MercadoPagoAdapter(new MercadoPago());
            newpayment.PayPalPayment();
            newpayment.PayPalReceive();

            Console.ReadKey();
        }
    }
}
