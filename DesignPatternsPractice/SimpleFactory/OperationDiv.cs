using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (numB == 0)
            {
                throw new Exception("除數不能為0");
            }
            double result = 0;
            result = numA / numB;
            return result;
        }
    }
}
