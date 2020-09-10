using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.BRE.BusinessComponents
{
    public class Book :IPayment, IPaymentDuplicatePackagingSlip, IPaymentCommissionToAgent
    {
        public bool CommissionToAgent()
        {
            Console.WriteLine("Commssion payment to agent");
            return true;
        }

        public bool GenerateDuplicatePackagingSlip()
        {
            Console.WriteLine("Duplicate Packing slip for royalty department");
            return true;
        }

        public bool PaymentProcess()
        {
            GenerateDuplicatePackagingSlip();

            CommissionToAgent();
            return true;
        }
    }
}
