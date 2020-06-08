using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.BusinessRuleEngine
{
    enum Payment
    {
        Product,
        Book,
        Membership,
        UpgradeMembership,
        Video
    }
    class PaymentTypeChecker
    {
        IPaymentFactory factory;
        Payment paymentType;

        public PaymentTypeChecker(Payment type)
        {
            paymentType = type;
        }

        public void CheckPayments()
        {
            switch (paymentType)
            {
                case Payment.Product:
                    {
                        factory = new ProductPaymentFactory();
                        Console.WriteLine(paymentType.ToString() + ":\n" + factory.ProductBookPayment().PackingSlip() + "\n" + factory.ProductBookPayment().GenerateCommissionPayment());
                        break;
                    }
                case Payment.Book:
                    {
                        factory = new BookPaymentFactory();
                        Console.WriteLine(paymentType.ToString() + ":\n" + factory.ProductBookPayment().PackingSlip() + "\n" + factory.ProductBookPayment().GenerateCommissionPayment());
                        break;
                    }
                case Payment.Membership:
                    {
                        factory = new MembershipPaymentFactory();
                        Console.WriteLine(paymentType.ToString() + ":\n" + factory.MembershipPayment().UpgradeMembershipDetails() + "\n" + factory.MembershipPayment().SendEmail());
                        break;
                    }
                case Payment.UpgradeMembership:
                    {
                        factory = new MembershipUpgradePaymentFactory();
                        Console.WriteLine(paymentType.ToString() + ":\n" + factory.MembershipPayment().UpgradeMembershipDetails() + "\n" + factory.MembershipPayment().SendEmail());
                        break;
                    }
                case Payment.Video:
                    {
                        factory = new ProductPaymentFactory();
                        Console.WriteLine(paymentType.ToString() + ":\n" + factory.ProductBookPayment().AddFirstAidVideo());
                        break;
                    }
            }
        }
    }
}
