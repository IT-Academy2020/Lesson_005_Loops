using System;

// Спрощений цикл Павук (Spider).

namespace Loop
{
    class Program
    {
        static void Main()
        {
            char character = '\0';            

            for (; ; )
            {
                character = Console.ReadKey().KeyChar;

                switch (character)
                {
                    case 'l': // 'l' - умова вартового 1.
                        {
                            Console.WriteLine("Go left"); continue; // команда вартового.
                        }
                    case 'r': // 'r' - умова вартового 1.
                        {
                            Console.WriteLine("Go right"); continue; // команда вартового.
                        }
                }

                switch (character)
                {
                    case 'x': // 'x' - умова виходу 1.
                        {
                            Console.WriteLine("Exit"); break; // команда завершення.
                        }
                    case 'q': // 'q' - умова виходу 2.
                        {
                            Console.WriteLine("Quit"); break; // команда завершення.
                        }
                    default: // Гілка альтернативного завершення.
                        {
                            Console.WriteLine("Alternative exit"); break;
                        }
                }
                                
                break;  // Переривання циклу.
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
