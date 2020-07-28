using System;
using System.Text;

// Циклічна конструкція - for (цикл з лічильником).

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // for (Ініціалізація лічильника ітерацій; Умова; Зміна лічильника) {Тіло циклу}

            for (int counter = 0; counter < 3; counter++)
            {
                Console.WriteLine("Counter = {0}", counter);
            }

            // counter = 0; // counter - недоступний за межами циклу for.

            // Delay.
            Console.ReadKey();
        }
    }
}
