using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.BRE.BusinessComponents
{
    public class PaymentProcessFactory 
    {
         public static IPayment Payment(string paymentType)
        {
            IPayment _IPayment;

            if(paymentType == PaymentType.PhysicalProduct.ToString())
            {
                _IPayment = new PhysicalProduct();
            }
            else
            {
                _IPayment = null;
            }

            return _IPayment;
        }
    }
}
