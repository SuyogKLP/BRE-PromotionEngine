using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.BusinessRuleEngine
{
    //Defining Abstract Factory 
    interface IPaymentFactory
    {
        IProductBookPayment ProductBookPayment();
        IMembershipUpgradePayment MembershipPayment();
    }

    //Defining Concrete Factories
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

    //Defining factory types
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
