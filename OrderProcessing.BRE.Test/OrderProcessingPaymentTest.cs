using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessing.BRE.BusinessComponents;

namespace OrderProcessing.BRE.Test
{
    [TestClass]
    public class OrderProcessingPaymentTest
    {
        [TestMethod]
        public void PaymentShouldGeneratePackingSlipForPhysicalProduct()
        {
            int physicalProduct = PaymentType.PhysicalProduct.GetHashCode();
            IPayment payment = PaymentProcessFactory.Payment(physicalProduct);
            bool result = payment.PaymentProcess();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentCreateDuplicatePackagingSlipRoyaltyDepForBook()
        {
            int book = PaymentType.Book.GetHashCode();
            IPayment paymentObject = PaymentProcessFactory.Payment(book);
            bool result = paymentObject.PaymentProcess();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactoryShouldActiavteMembership()
        {
            int membershipActivate = PaymentType.MembershipActivate.GetHashCode();
            IPayment payment = PaymentProcessFactory.Payment(membershipActivate);
            bool result = payment.PaymentProcess();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactoryShouldUpgradeMembership()
        {
            int membershipUpgrade = PaymentType.MembershipUpgrade.GetHashCode();
            IPayment payment = PaymentProcessFactory.Payment(membershipUpgrade);
            bool result = payment.PaymentProcess();
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void PaymentFactoryShouldGenerateFreeVideoSlip()
        {
            int video = PaymentType.Video.GetHashCode();
            IPayment payment = PaymentProcessFactory.Payment(video);
            bool result = payment.PaymentProcess();
            Assert.AreEqual(result, true);
        }
    }
}
