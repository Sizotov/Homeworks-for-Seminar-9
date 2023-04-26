//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных
//элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

using System;
using static System.Console;
Clear();
Write("Введите значение M: ");
int m = int.Parse (ReadLine());
Write("Введите значение N: ");
int n = int.Parse (ReadLine());
int summa(int m, int n)
{
if (m==n)
return n;
else return m + summa(m + 1, n);
}
Write ($"Сумма натуральных элементов в промежутке от M до N равна {summa(m,n)}");