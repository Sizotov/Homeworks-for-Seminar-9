//Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse (ReadLine());
int count = 1;
WriteNow (number, count);
void WriteNow (int n, int count)
{
    if (count > n)
    {
       return;
    }
    else
    {
    WriteNow (n, ++count);
    Write (count+ ", ");
    }

}
