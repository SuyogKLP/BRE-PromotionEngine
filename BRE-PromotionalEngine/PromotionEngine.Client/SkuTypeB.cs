using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    public class SkuTypeB : Sku
    {
        private double _TypeOrderValue;
        public override double ActivePromotion(int numberOfUnits)
        {
            Name = "B";
            UnitPrice = 30;
            PromotionValue = 45;

            int j = numberOfUnits % 2;
            if (j == 0)
            {
                _TypeOrderValue = (numberOfUnits / 2) * PromotionValue;
            }
            else
            {
                _TypeOrderValue = (numberOfUnits / 2) * PromotionValue + (j * UnitPrice);
            }
            return _TypeOrderValue;
        }
    }
}
