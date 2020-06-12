using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    public enum SkuType
    {
        A,
        B,
        C,
        D,
        CD
    }

    /// <summary>
    /// Designed using factory pattern
    /// </summary>
    public class SkuFactory
    {      
        static public ISku CreateandReturnObj(SkuType skuType)
        {
            ISku ObjSelector = null;

            switch (skuType)
            {
                case SkuType.A:
                    ObjSelector = new SkuTypeA();
                    break;
                case SkuType.B:
                    ObjSelector = new SkuTypeB();
                    break;
                case SkuType.C:
                    ObjSelector = new SkuTypeC();
                    break;
                case SkuType.D:
                    ObjSelector = new SkuTypeD();
                    break;
                case SkuType.CD:
                    ObjSelector = new SkuTypeCD();
                    break;
            }
            return ObjSelector;
        }
    }
}
