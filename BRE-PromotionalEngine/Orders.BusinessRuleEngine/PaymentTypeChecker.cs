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
    class PaymentType
    {
        IPaymentFactory factory;
        Payment paymentType;

        public PaymentType(Payment type)
        {
            paymentType = type;
        }

        public void MakePayment()
        {
            switch (paymentType)
            {
                case Payment.Product:
                    {
                        factory = new ProductBookPaymentFactory();
                        Console.WriteLine(paymentType.ToString() + ":\n" + factory.ProductBookPayment().PackingSlip() + "\n" + factory.ProductBookPayment().GenerateCommissionPayment());
                        break;
                    }
                case Payment.Book:
                    {
                        factory = new MembershipPaymentFactory();
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
                        factory = new ProductBookPaymentFactory();
                        Console.WriteLine(paymentType.ToString() + ":\n" + factory.MembershipPayment().UpgradeMembershipDetails() + "\n" + factory.MembershipPayment().SendEmail());
                        break;
                    }
                case Payment.Video:
                    {
                        factory = new ProductBookPaymentFactory();
                        Console.WriteLine(paymentType.ToString() + ":\n" + factory.ProductBookPayment().LearningToSki());
                        break;
                    }
            }
        }
    }
}
