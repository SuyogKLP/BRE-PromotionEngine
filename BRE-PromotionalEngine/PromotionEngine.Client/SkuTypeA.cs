using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    public class SkuTypeA : Sku
    {
        private double _TypeOrderValue;
        public override double ActivePromotion(int numberOfUnits)
        {
            Name = "A";
            UnitPrice = 50;
            PromotionValue = 130;

            int j = numberOfUnits % 3;
            if (j == 0)
            {
                _TypeOrderValue = (numberOfUnits / 3) * PromotionValue;
            }
            else
            {
                _TypeOrderValue = (numberOfUnits / 3) * PromotionValue + (j * UnitPrice);
            }
            return _TypeOrderValue;
        }
    }
}
