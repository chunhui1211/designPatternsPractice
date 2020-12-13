using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.example
{
    //ConcreteComponent
    public class Person
    {
        public Person()
        { }
        private string name;
        public Person(string nam)
        {
            this.name = nam;
        }
        public virtual void Show()
        {
            Console.WriteLine("裝扮的{0}", name);
        }
    }
}
