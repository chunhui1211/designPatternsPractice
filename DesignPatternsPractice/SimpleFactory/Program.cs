using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("請輸入數字A");
                string strNumA = Console.ReadLine();
                Console.WriteLine("請輸入數字運算符號(+、-、*、/):");
                string strOperate = Console.ReadLine();
                Console.WriteLine("請輸入數字B");
                string strNumB = Console.ReadLine();

                var oper = OperationFactory.CreateOperation(strOperate);
                oper.numA = Convert.ToDouble(strNumA);
                oper.numB = Convert.ToDouble(strNumB);
                Console.WriteLine("結果是:" + oper.GetResult());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("輸入有錯:" + ex.Message);
            }
        }
    }
}
