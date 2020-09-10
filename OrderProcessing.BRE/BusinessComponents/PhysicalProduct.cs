using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.BRE.BusinessComponents
{
    public class PhysicalProduct : IPayment, IPackagingSlip, IPaymentCommissionToAgent
    {
        public bool CommissionToAgent()
        {
            Console.WriteLine("Commssion Payment to agent");
            return true;
        }

        public bool GeneratePackagingSlip()
        {
            //TODO implementation for genrate a packaging slip
            Console.WriteLine("Generated a Packaging slip for shipping");
            return true;
        }
        //Payament process for physical product
        public bool PaymentProcess()
        {            
            GeneratePackagingSlip();

            CommissionToAgent();

            return true;
        }


    }
}
