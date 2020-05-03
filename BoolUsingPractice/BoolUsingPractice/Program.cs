using System;

namespace BoolUsingPractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("10 > 9 is " + (10 > 9));
            Console.WriteLine("100 < 50 is " + (100 < 50));
            Console.WriteLine("100 <= 100 is " + (100 <= 100));
            Console.WriteLine("100 >= 200 is " + (100 >= 200));
            Console.WriteLine("100 = 30 is " + (100 == 30));
        }
    }
}
