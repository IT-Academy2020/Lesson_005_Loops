using System;

// Оператор безумовного переходу - goto.

namespace Loop
{
    class Program
    {
        static void Main()
        {

            // Label - це мітка, на яку буде проведений перехід оператором goto.

            Label: Console.WriteLine("Hello!");
            goto Label;

        }
    }
}
