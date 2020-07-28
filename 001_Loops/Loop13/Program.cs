using System;
using System.Text;

// Циклічна конструкція - for (цикл з лічильником). (З достроковим виходом з циклу - break).

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);

                break;

                Console.WriteLine("Цей рядок не виконається.");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
