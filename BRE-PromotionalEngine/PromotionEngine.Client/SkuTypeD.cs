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
            int unitC = 15;
            Name = "D";

            if (numberOfDUnits >= 1)
                _TypeOrderValue = unitC * numberOfDUnits;

            return _TypeOrderValue;
        }
    }
}
