﻿using System;

// Цикл Павук (Spider). Модифікований цикл Дейкстри з явними умовами виходу.

// Цикл Дейкстри не містить явної умови продовження або виходу.
// Тому була запропонована ускладнена конструкція циклу Дейкстри, що отримала назву "цикл-павук".

// В нотації Дейкстри вона виглядає наступним чином:

// do
//    P1→S1,
//      …
//    Pn→Sn
//  out
//    Q1→T1,
//      …
//    Qn→Tn
//  else
//    E
// od

// де:
// do - маркер початку конструкції циклу,
// od - маркер завершення конструкції циклу,
// Pi - i-та умова вартового (логічний вираз, який може мати значення «істинна» чи «хиба»),
// Si - i-та під команда вартового.
// Після маркера out додані гілки завершення, що складаються з умов виходу Qi і команд завершення Ti.
// Крім того, добавлена гілка альтернативного завершення else з командою E.

// Цикл-'паук 'виконується так:
// Обчислюються умова вартового.
// Якщо існує істинний вартовий, виконується відповідна команда.
// Обчислюються умови виходу.
// Якщо існує істинна умова виходу, виконується відповідна команда завершення, після чого виконання циклу завершується.
// Якщо всі умови виходу помилкові, починається наступна ітерація, але тільки в тому випадку, якщо в поточній ітерації
// було істинним хоча б одна умова вартового
// Якщо в даній ітерації виявилися помилковими і всі умови вартового, і всі умови виходу, виконується
// команда альтернативного завершення E, після чого виконання циклу переривається.

namespace Loop
{
    class Program
    {
        static void Main()
        {
            char character = '\0';
            
            bool flag = default(bool);

            for (; ; )
            {
            Start:
                flag = false;
                character = Console.ReadKey().KeyChar;

                switch (character)
                {
                    case 'l': // 'l' -  умова вартового 1.
                        {
                            Console.WriteLine("Go left"); flag = true; break; // команда вартового.
                        }
                    case 'r': // 'r' -  умова вартового 2.
                        {
                            Console.WriteLine("Go right"); flag = true; break; // команда вартового.
                        }
                }

                switch (character)
                {
                    case 'x': // 'x' - умова виходу 1.
                        {
                            Console.WriteLine("Exit"); goto End; // команда завершення.
                        }
                    case 'q': // 'q' - умова виходу 2.
                        {
                            Console.WriteLine("Quit"); goto End; // команда завершення.
                        }
                }

                // Гілка альтернативного завершення.
                if (flag)
                {
                    goto Start;
                }

                Console.WriteLine("Alternative exit");

            End:
                break;  // Переривання циклу.
            }

            // Delay.
            Console.ReadKey();
        }
    }
}