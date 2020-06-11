using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    public interface ISku
    {
        string Name { get; set; }
        int UnitPrice { get; set; }
        int PromotionValue { get; set; }
        double ActivePromotion(int numberOfUnits);
    }
}
