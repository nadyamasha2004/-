using System;

namespace Дмитриева__Акимова_М
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] mas = new int[20];
            Random rnd = new Random();


            for (int i = 0; i < 20; i++)
            {
                mas[i] = rnd.Next(0,20) ;
                if ((mas[i] % 7 == 5) || mas[i] % 7 == 1|| mas[i] % 7 == 2)
                {
                    Console.WriteLine("{0}", mas[i]);
                }

                else
                {
                    
                }
               

        }
    }
    }
}
