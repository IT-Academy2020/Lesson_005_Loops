﻿using System;
using System.Text;

// Циклічна конструкція - do-while.

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int counter = 0;

            do
            {
                counter++;
                Console.WriteLine("Counter {0}", counter);
            }
            while (counter < 3);

            Console.WriteLine("Виконано {0} ітерацій.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
