using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.example
{
    //Decorator
    public class Finery : Person
    {
        protected Person component;
        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }
}
