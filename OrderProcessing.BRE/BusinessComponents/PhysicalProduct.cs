using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.BRE.BusinessComponents
{
    public class PhysicalProduct : IPayment, IPackingSlip, IPaymentCommissionToAgent
    {
        public bool CommissionToAgent()
        {
            Console.WriteLine("Commssion Payment to agent");
            return true;
        }

        public bool GeneratePackingSlip()
        {
            Console.WriteLine("Generated a Packing slip for shipping");
            return true;
        }

        //Payament process for physical product
        public bool PaymentProcess()
        {
            GeneratePackingSlip();

            CommissionToAgent();

            return true;
        }


    }
}
