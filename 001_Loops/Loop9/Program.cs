using System;
using System.Text;

// Циклічна конструкція - do-while. (З достроковим виходом з циклу - break)

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

                break;

                Console.WriteLine("Цей рядок не виконається.");
            }
            while (counter < 3) ;

            Console.WriteLine("Виконано {0} ітерацій.", counter);

            // Delay.
            Console.ReadKey();
        }
    }
}
