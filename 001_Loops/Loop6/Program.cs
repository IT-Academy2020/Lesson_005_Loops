﻿using System;
using System.Text;

// Циклічна конструкція - while. (з пропуском ітерації - continue)

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int counter = 0;

            while (counter < 3)
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);

                continue;

                Console.WriteLine("Цей рядок не виконається.");
            }

            Console.WriteLine("Виконано {0} ітерацій.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
