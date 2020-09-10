using OrderProcessing.BRE.BusinessComponents;
using System;

namespace OrderProcessing.BRE
{
    class Program
    {
        static void Main(string[] args)
        {
            int paymentStatus;
            Console.WriteLine("Please Select Order Type:");
            Console.WriteLine("1:PhysicalProduct \n" +
                              "2:Book\n" +
                              "3:MembershipActivate\n" +
                              "4:MembershipUpgrade\n" +
                              "5:Video\n");

            var paymentType = Console.ReadLine();

           
            if (Int32.TryParse(paymentType, out paymentStatus))
            {
                OrderPaymentProcess(paymentStatus);
            }
            else
            {
                Console.WriteLine("Please select valid payment type !");
            }
            Console.Read();

        }

        private static void OrderPaymentProcess(int PaymentType)
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
