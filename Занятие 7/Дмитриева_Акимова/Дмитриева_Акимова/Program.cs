using System;

namespace Дмитриева_Акимова
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("+++++");
            Console.WriteLine("|i   |y  |");
            for (double i = -Math.PI; i < Math.PI; i =i+ Math.PI / 4)
            {
                double y = Math.Cos(i) * Math.Cos(i);
                Console.WriteLine("|{0:0.0}|{1:0.0}|",i, y);
            }

            Console.WriteLine("+++++"); 
            Console.WriteLine("I hate you, World!");
        }
    }
}

