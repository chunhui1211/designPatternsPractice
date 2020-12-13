using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CashContext
    {
        private CashSuper cs;
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收費":
                    var cs0 = new CashNormal();
                    cs = cs0;
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
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
