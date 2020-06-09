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
            //Achieved solution using Abstract factory pattern
            PaymentType paymentType = new PaymentType(Payment.Product);
            paymentType.MakePayment();
            Console.WriteLine("\nPress enter for new Payment");
            Console.ReadLine();

            paymentType = new PaymentType(Payment.Book);
            paymentType.MakePayment();
            Console.WriteLine("\nPress enter for new Payment");
            Console.ReadLine();

            paymentType = new PaymentType(Payment.Membership);
            paymentType.MakePayment();
            Console.WriteLine("\nPress enter for new Payment");
            Console.ReadLine();

            paymentType = new PaymentType(Payment.UpgradeMembership);
            paymentType.MakePayment();
            Console.WriteLine("\nPress enter for new Payment");
            Console.ReadLine();

            paymentType = new PaymentType(Payment.Video);
            paymentType.MakePayment();          
            Console.ReadLine();
        }
    }
}
