using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.BRE.BusinessComponents
{
    public interface IEmailNotification
    {
        bool EmailNotificationToOwner();
    }
}
