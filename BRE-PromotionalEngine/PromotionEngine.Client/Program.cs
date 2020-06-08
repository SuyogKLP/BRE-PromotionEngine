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
            double TotalValue = 0;
            Console.Write("Enter number of Units For A: ");
            int numberA = int.Parse(Console.ReadLine());
            SkuTypeA obj1 = new SkuTypeA();
            double result = obj1.ActivePromotion(numberA);
            TotalValue = TotalValue + result;

            Console.Write("Enter number of Units For B: ");
            int numberB = int.Parse(Console.ReadLine());
            SkuTypeB obj2 = new SkuTypeB();
            result = obj2.ActivePromotion(numberB);
            TotalValue = TotalValue + result;

            Console.Write("Enter number of Units For C : ");
            int numberC = int.Parse(Console.ReadLine());

            Console.Write("Enter number of Units For D : ");
            int numberD = int.Parse(Console.ReadLine());

            if (numberC > 0 && numberD > 0)
            {
                SkuTypeCD obj3 = new SkuTypeCD();
                result = obj3.ActivePromotion(numberC, numberD);
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
                result = obj3.ActivePromotion(numberC);
                TotalValue = TotalValue + result;
            }

            Console.WriteLine("Final Total Order Value : " + TotalValue);

            Console.ReadLine();
        }
    }
}
