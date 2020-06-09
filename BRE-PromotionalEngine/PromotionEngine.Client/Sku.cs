using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    public class Sku
    {
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int PromotionValue { get; set; }
        public virtual double ActivePromotion(int numberOfUnits) { return 0; }
    }
}
