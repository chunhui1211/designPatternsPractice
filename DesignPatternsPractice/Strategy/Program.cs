using Strategy;
using System;

namespace Strategy1
{
    class Program
    {
        static void Main(string[] args)
        {
            CashContext csuper = new CashContext("打8折");
            var result = csuper.GetResult(300);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
