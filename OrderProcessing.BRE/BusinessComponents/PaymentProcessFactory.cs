using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.BRE.BusinessComponents
{
    public class PaymentProcessFactory 
    {
        //need refactory the code for more decouple the classes
         public static IPayment Payment(int paymentType)
        {
            IPayment _IPayment;

            if(paymentType == PaymentType.PhysicalProduct.GetHashCode())
            {
                _IPayment = new PhysicalProduct();
            }
            else
            if (paymentType == PaymentType.Book.GetHashCode())
            {
                _IPayment = new Book();
            }
            else
            if (paymentType == PaymentType.MembershipActivate.GetHashCode())
            {
                _IPayment = new MembershipActivate();
            }
            else
            if (paymentType == PaymentType.MembershipUpgrade.GetHashCode())
            {
                _IPayment = new MembershipUpgrade();
            }
            else
            if (paymentType == PaymentType.Video.GetHashCode())
            {
                _IPayment = new Video();
            }
            else
            {
                _IPayment = null;
            }

            return _IPayment;
        }
    }
}
