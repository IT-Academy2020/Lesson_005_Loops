using System;
using System.Text;

// Цикл for вкладений в цикл for. (Побудова квадрата з зірочок - *)

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            for (int i = 0; i < 10; i++)
            {
                // Виводимо один рядок з 10 зірочок.
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }

                // Перехід на новий рядок.
                Console.WriteLine();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
