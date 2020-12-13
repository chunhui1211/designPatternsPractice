using Decorator.example;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();

            //範例
            Person xc = new Person("小菜");
            var kk = new BigTrouser();
            var dtx = new TShirts();
            kk.Decorate(xc);
            dtx.Decorate(kk);
            dtx.Show();

            Console.ReadLine();
        }
    }
}
