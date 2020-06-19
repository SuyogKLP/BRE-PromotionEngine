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

            //Here calling all one by one for calculating all amounts.
            //We can conditionally create instance and process the order accordingly.
            //To calculate all order (sum) i'm assuming user will accept number of products (units)

            ISku ObjInterface = null;
                       
            Console.Write("Enter number of Units For A: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                ObjInterface = SkuFactory.CreateandReturnObj(SkuType.A);
                result = ObjInterface.ActivePromotion(Convert.ToInt32(input));
                TotalValue += result;
            }

            Console.Write("Enter number of Units For B: ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                ObjInterface = SkuFactory.CreateandReturnObj(SkuType.B);
                result = ObjInterface.ActivePromotion(Convert.ToInt32(input));
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
                ObjInterface = SkuFactory.CreateandReturnObj(SkuType.CD);
                int totalNumberofUnits = numberC + numberD;
                result = ObjInterface.ActivePromotion(totalNumberofUnits);
                TotalValue = TotalValue + result;
                flag = true;
            }
            if (numberC >= 1 && (!flag))
            {
                ObjInterface = SkuFactory.CreateandReturnObj(SkuType.C);
                result = ObjInterface.ActivePromotion(numberC);
                TotalValue = TotalValue + result;
            }

            if (numberD >= 1 && (!flag))
            {
                ObjInterface = SkuFactory.CreateandReturnObj(SkuType.D);
                result = ObjInterface.ActivePromotion(numberD);
                TotalValue = TotalValue + result;
            }

            Console.WriteLine("Final Total Order Value : " + TotalValue);

            Console.ReadLine();
        }
    }
}
