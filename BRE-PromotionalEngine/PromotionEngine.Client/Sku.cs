using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    public class Sku
    {
        protected string Name { get; set; }
        protected int UnitPrice { get; set; }
        protected int PromotionValue { get; set; }
        public virtual double ActivePromotion(int numberOfUnits) { return 0; }
        public virtual double ActivePromotion(int numberC, int numberD) { return 0; }
    }
}
