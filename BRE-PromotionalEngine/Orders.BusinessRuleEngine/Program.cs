using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.BusinessRuleEngine
{  
    class Program
    {
        static void Main(string[] args)
        {
            PaymentTypeChecker checker = new PaymentTypeChecker(Payment.Product);
            checker.CheckPayments();
            Console.WriteLine("Press enter for new Payment");
            Console.ReadLine();

            checker = new PaymentTypeChecker(Payment.Book);
            checker.CheckPayments();
            Console.WriteLine("Press enter for new Payment");
            Console.ReadLine();

            checker = new PaymentTypeChecker(Payment.Membership);
            checker.CheckPayments();
            Console.WriteLine("Press enter for new Payment");
            Console.ReadLine();

            checker = new PaymentTypeChecker(Payment.UpgradeMembership);
            checker.CheckPayments();
            Console.WriteLine("Press enter for new Payment");
            Console.ReadLine();

            checker = new PaymentTypeChecker(Payment.Video);
            checker.CheckPayments();
            Console.WriteLine("Press enter for new Payment");
            Console.ReadLine();
        }
    }
}
