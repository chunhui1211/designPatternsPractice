using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Operation
    {
        public static double GetResult(double strNumA, double strNumB, string strOperate)
        {
            double result = 0d;
            switch (strOperate)
            {
                case "+":
                    result = strNumA + strNumB;
                    break;
                case "-":
                    result = strNumA - strNumB;
                    break;
                case "*":
                    result = strNumA * strNumB;
                    break;
                case "/":
                    result = strNumA / strNumB;
                    break;
            }
            return result;
        }
    }
}
