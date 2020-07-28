using System;
using System.Text;

// Циклічна конструкція - while.

// Факторіал числа n (позначається n !, вимовляється - ен факторіал) - це добуток всіх натуральних чисел,
// від 1 до n включно:
//     n! = 1 * 2 * 3 * ... * n
//     0! = 1

// В комбінаториці факторіал натурального числа n інтерпретується як кількість перестановок множини з n елементів.
// Наприклад, для множини {A, B, C, D} з 4-х елементів існує: 4! = 1 * 2 * 3 * 4 = 24 перестановки:

//     ABCD  BACD  CABD  DABC
//     ABDC  BADC  CADB  DACB
//     ACBD  BCAD  CBAD  DBAC
//     ACDB  BCDA  CBDA  DBCA
//     ADBC  BDAC  CDAB  DCAB
//     ADCB  BDCA  CDBA  DCBA

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int counter = 4;
            int factorial = 1;

            Console.Write("Факторіал числа: {0}! = ", counter);

            do
            {
                // Спочатку множення, потім декремент.
                factorial *= counter--;

                // Цей рядок еквівалентний:

                //factorial = factorial * counter;
                //counter = counter - 1;
            }
            while (counter > 0);

            Console.WriteLine("{0}", factorial);

            // Delay.
            Console.ReadKey();
        }
    }
}
