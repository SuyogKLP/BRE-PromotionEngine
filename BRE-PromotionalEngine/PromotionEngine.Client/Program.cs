using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            double result = 0;
            int numberC = 0;
            int numberD = 0;
            double TotalValue = 0;
            Console.Write("Enter number of Units For A: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                SkuTypeA obj1 = new SkuTypeA();
                result = obj1.ActivePromotion(Convert.ToInt32(input));
                TotalValue += result;
            }

            Console.Write("Enter number of Units For B: ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                SkuTypeB obj2 = new SkuTypeB();
                result = obj2.ActivePromotion(Convert.ToInt32(input));
                TotalValue += result;
            }
            
            Console.Write("Enter number of Units For C : ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                numberC = Convert.ToInt32(input);
            }

            Console.Write("Enter number of Units For D : ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                numberD = Convert.ToInt32(input);
            }

            if (numberC > 0 && numberD > 0)
            {
                SkuTypeCD obj3 = new SkuTypeCD();
                int totalNumberofUnits = numberC + numberD;
                result = obj3.ActivePromotion(totalNumberofUnits);
                TotalValue = TotalValue + result;
                flag = true;
            }
            if (numberC >= 1 && (!flag))
            {
                SkuTypeC obj3 = new SkuTypeC();
                result = obj3.ActivePromotion(numberC);
                TotalValue = TotalValue + result;
            }

            if (numberD >= 1 && (!flag))
            {
                SkuTypeD obj3 = new SkuTypeD();
                result = obj3.ActivePromotion(numberD);
                TotalValue = TotalValue + result;
            }

            Console.WriteLine("Final Total Order Value : " + TotalValue);

            Console.ReadLine();
        }
    }
}
