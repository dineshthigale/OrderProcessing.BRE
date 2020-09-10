using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.BRE.BusinessComponents
{
    public class Video : IPayment , IPackingSlip
    {
        public bool GeneratePackingSlip()
        {
            Console.WriteLine("Generated a Packaging slip for shipping");
            return true;
        }

        public bool PaymentProcess()
        {
            GeneratePackingSlip();

            AddFreeVideotoPackingSlip();
            return true;
        }

        private bool AddFreeVideotoPackingSlip()
        {
            Console.WriteLine("Added free First Aid video");
            return true;
        }
    }
}
