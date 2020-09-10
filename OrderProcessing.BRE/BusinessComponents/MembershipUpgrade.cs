using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.BRE.BusinessComponents
{
    public class MembershipUpgrade : IPayment, IPaymentMembershipUpgrade, IEmailNotification
    {
        public bool EmailNotificationToOwner()
        {
            Console.WriteLine("Email notification sent to the owner");
            return true;
        }

        public bool PaymentProcess()
        {
            UpgradeMembership();

            EmailNotificationToOwner();

            return true;

        }

        public bool UpgradeMembership()
        {
            Console.WriteLine("Membership upgraded");
            return true;
        }
    }
}
