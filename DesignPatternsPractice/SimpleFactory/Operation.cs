﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Operation
    {
        public double numA { get; set; }
        public double numB { get; set; }
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
