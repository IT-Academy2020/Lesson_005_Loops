using System;
using System.Text;

// Циклічна конструкція - while. 

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Вгадайте загаданий колір з п'яти спроб.");
            Console.WriteLine("Для виходу з програми ви можете набрати - exit.");

            const int maxAttempt = 5; // Допустима кількість спроб.
            int attempt = 0;          // Лічильник спроб.
            string color = "red";     // Загаданий колір.

            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("Спроба {0}:", attempt);
                
                string value = Console.ReadLine();

                if (value == "exit")
                {
                    break;
                }

                if (value != color)
                {
                    continue;
                }

                Console.WriteLine("Вітаємо, Ви вгадали з {0} спроби!", attempt);
                break;
            }

            Console.WriteLine("Кінець гри!");

            // Delay.
            Console.ReadKey();
        }
    }
}
