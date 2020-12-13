using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.example
{
    //ConcreteDecorator
    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.WriteLine("大T恤");
            base.Show();
        }
    }
}
