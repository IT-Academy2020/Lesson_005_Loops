﻿using System;

// Цикл Дейкстри.

// При виконанні циклу Дейкстри в кожній ітерації відбувається обчислення умов вартових. 
// Якщо хоча б одне з них істинне, виконується відповідна команда, яка охороняється, після чого починається нова ітерація
// (Якщо істинні кілька умов вартових, виконується тільки одна команда, яка охороняється).
// Якщо всі умови вартових помилкові, цикл завершується.
// Цикл Дейкстри з одною умовою вартового і однією командою, яка охороняється, є, по суті, звичайним циклом з передумовою (цикл «while»).

// Класичний опис циклу Дейкстри.
// do
//   P1 → S1,
//     …
//   Pn → Sn
// od

// де:
// do - маркер початку конструкції циклу,
// od - маркер завершення конструкції циклу,
// Pi - i-та Умова вартового (логічний вираз, який може мати значення «істинно» чи «хибно»),
// Si - i-та команда, яка охороняється.

// Цикл складається з однієї або декількох гілок,
// кожна з яких представляє собою пару з умови вартового і команди, яка охороняється.

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
                    case 'l': // 'l' -  умова вартового 1.
                        {
                            Console.WriteLine("Go left");    // команда яка охороняється.
                            continue; 
                        }
                    case 'r': // 'r' -  умова вартового 2.
                        {
                            Console.WriteLine("Go right");   // команда яка охороняється.
                            continue;
                        }
                }
                break;  // Переривання циклу.
            }

            // Delay.
            // Console.ReadKey();
        }
    }
}