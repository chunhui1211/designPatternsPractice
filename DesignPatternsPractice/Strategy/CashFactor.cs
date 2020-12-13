using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CashFactor
    {
        public static CashSuper createCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "正常收費":
                    cs = new CashNormal();
                    break;
                case "滿300送100":
                    var cr1 = new CashReturn("300", "100");
                    cs = cr1;
                    break;
                case "打8折":
                    var cr2 = new CashRebate("0.8");
                    cs = cr2;
                    break;
            }

            return cs;
        }
    }
}
