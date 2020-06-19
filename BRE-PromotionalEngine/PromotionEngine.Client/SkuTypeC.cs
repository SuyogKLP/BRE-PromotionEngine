using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    public class SkuTypeC : ISku
    {
        private double _TypeOrderValue;
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int PromotionValue { get; set; }
        public double ActivePromotion(int numberOfCUnits)
        {
            Name = "C";
            UnitPrice = 20;

            if (numberOfCUnits >= 1)
                _TypeOrderValue = UnitPrice * numberOfCUnits;

            return _TypeOrderValue;
        }
    }
}
