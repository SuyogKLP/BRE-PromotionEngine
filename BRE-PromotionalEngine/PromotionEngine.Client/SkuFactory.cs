using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Client
{
    /// <summary>
    /// Designed using factory pattern
    /// </summary>
    public class SkuFactory
    {
        static public ISku CreateandReturnObj(int cChoice)
        {
            ISku ObjSelector = null;

            switch (cChoice)
            {
                case 1:
                    ObjSelector = new SkuTypeA();
                    break;
                case 2:
                    ObjSelector = new SkuTypeB();
                    break;
                case 3:
                    ObjSelector = new SkuTypeC();
                    break;
                case 4:
                    ObjSelector = new SkuTypeD();
                    break;
                case 5:
                    ObjSelector = new SkuTypeCD();
                    break;
            }
            return ObjSelector;
        }
    }
}
