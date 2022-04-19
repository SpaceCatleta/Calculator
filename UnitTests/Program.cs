using ClassLibrary;
using System;


namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Testing() == 0)
                Console.WriteLine("All test completed.");
            else
                Console.WriteLine("Error found.");

            Console.ReadLine();
        }

        static int Testing()
        {
            MyCalc c = new MyCalc();

            if (c.ParseExpression("2+2") != 4)
                return -1;
            Console.WriteLine("add() passed");

            if (c.ParseExpression("13-5") != 8)
                return -1;
            Console.WriteLine("sub() passed");

            if (c.ParseExpression("3*6") != 18)
                return -1;
            Console.WriteLine("mul() passed");

            if (c.ParseExpression("18/3") != 6)
                return -1;
            Console.WriteLine("div() passed");


            return 0;
        }
    }
}
