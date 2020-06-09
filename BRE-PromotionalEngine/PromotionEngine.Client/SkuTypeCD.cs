using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    public class SkuTypeCD : Sku
    {
        private double _TypeOrderValue;
        public override double ActivePromotion(int numberOfUnits)
        {           
            int unitC = 15; int UnitD = 20;
            Name = "C & D";
            UnitPrice = unitC + UnitD;
            PromotionValue = 30;
          
            if (numberOfUnits > 1)
            {                
                int j = numberOfUnits % 2;
                if (j == 0)
                    _TypeOrderValue = (numberOfUnits / 2) * PromotionValue;
                else
                    _TypeOrderValue = (numberOfUnits / 2) * PromotionValue + (j * UnitPrice);
            }

            return _TypeOrderValue;
        }
    }
}
