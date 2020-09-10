using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.BRE.BusinessComponents
{
    public class MembershipActivate : IPayment, IPaymentMembershipActivate, IEmailNotification
    {
        public bool ActivateMembership()
        {
            Console.WriteLine("Membership activated");
            return true;
        }

        public bool EmailNotificationToOwner()
        {
            Console.WriteLine("Email notification sent to the owner");
            return true;
        }

        public bool PaymentProcess()
        {
            ActivateMembership();

            EmailNotificationToOwner();

            return true;
        }

    }
}
