using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.BusinessRuleEngine
{
    interface IPaymentFactory
    {
        IProductBookPayment ProductBookPayment();
        IMembershipUpgradePayment MembershipPayment();
    }

    class ProductBookPaymentFactory : IPaymentFactory
    {
        public IMembershipUpgradePayment MembershipPayment()
        {
            return new UpgradeMembership();
        }

        public IProductBookPayment ProductBookPayment()
        {
            return new Product();
        }
    }


    class MembershipPaymentFactory : IPaymentFactory
    {
        public IMembershipUpgradePayment MembershipPayment()
        {
            return new Membership();
        }

        public IProductBookPayment ProductBookPayment()
        {
            return new Book();
        }
    }
            
}
