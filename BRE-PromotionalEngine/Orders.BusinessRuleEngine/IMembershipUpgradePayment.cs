using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.BusinessRuleEngine
{
    interface IMembershipUpgradePayment
    {
        string UpgradeMembershipDetails();
        string SendEmail();
    }

    class Membership : IMembershipUpgradePayment
    {
        public string SendEmail()
        {
            return "Email sent to owner for the activation";
        }

        public string UpgradeMembershipDetails()
        {
            return "Membership activated!";
        }
    }
    class UpgradeMembership : IMembershipUpgradePayment
    {
        public string SendEmail()
        {
            return "Email sent to owner for the upgradation";
        }

        public string UpgradeMembershipDetails()
        {
            return "Membership upgraded!";
        }
    }
}
