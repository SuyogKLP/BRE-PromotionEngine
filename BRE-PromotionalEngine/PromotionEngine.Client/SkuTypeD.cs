using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{ 
    public class SkuTypeD : Sku
    {
        private double _TypeOrderValue;
        public override double ActivePromotion(int numberOfDUnits)
        {
            Name = "D";
            UnitPrice = 15;

            if (numberOfDUnits >= 1)
                _TypeOrderValue = UnitPrice * numberOfDUnits;

            return _TypeOrderValue;
        }
    }
}
