using OrderProcessing.BRE.BusinessComponents;
using System;

namespace OrderProcessing.BRE
{
    class Program
    {
        static void Main(string[] args)
        {
            string paymentStatus = string.Empty;
            Console.WriteLine("Please Select Order Type:");
            Console.WriteLine("PhyiscalProduct\n" +
                              "Book\n" +
                              "MembershipActivate\n" +
                              "MembershipUpgrade\n" +
                              "Video\n");
            Console.WriteLine("Hello World!");

            var userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                OrderPaymentProcess(paymentStatus);
            }
            else
            {
                Console.WriteLine("Please select valid payment type !");
            }
            Console.Read();

        }

        private static void OrderPaymentProcess(string PaymentType)
        {
            IPayment payment = PaymentProcessFactory.Payment(PaymentType);
            if (payment == null)
            {
                Console.WriteLine("Invalid option selected!");
            }
            else
            {
                payment.PaymentProcess();
            }
        }
    }
}
