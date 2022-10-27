using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------");
            int j = 100;
            while(j > 50)
            {
                Console.WriteLine(j);
                j--;
            }
           

        }
    }
}
