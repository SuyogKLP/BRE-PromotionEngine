using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{ 
    public class SkuTypeD : ISku
    {
        private double _TypeOrderValue;
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int PromotionValue { get; set; }
        public double ActivePromotion(int numberOfDUnits)
        {
            Name = "D";
            UnitPrice = 15;

            if (numberOfDUnits >= 1)
                _TypeOrderValue = UnitPrice * numberOfDUnits;

            return _TypeOrderValue;
        }
    }
}
