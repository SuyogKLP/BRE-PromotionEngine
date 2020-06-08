﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{    
    public class SkuTypeC : Sku
    {
        private double _TypeOrderValue;
        public override double ActivePromotion(int numberOfCUnits)
        {
            int unitC = 20;
            Name = "C";
        
           if (numberOfCUnits >= 1)
                _TypeOrderValue = unitC * numberOfCUnits;

            return _TypeOrderValue;
        }
    }
}