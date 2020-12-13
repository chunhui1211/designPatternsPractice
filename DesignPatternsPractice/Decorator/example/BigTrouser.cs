using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.example
{
    //ConcreteDecorator
    public class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.WriteLine("垮褲");
            base.Show();
        }
    }
}
