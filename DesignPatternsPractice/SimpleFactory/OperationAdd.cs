using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = numA + numB;
            return result;
        }
    }
}
