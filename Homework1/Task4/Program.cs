// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using static System.Console;

Write("Введите число a ");
int a = int.Parse(ReadLine()!);

Write("Введите число b ");
int b = int.Parse(ReadLine()!);

Write("Введите число c ");
int c = int.Parse(ReadLine()!);
int max = a;

if(b > max ) max = b;
if(c > max ) max = c;
WriteLine($"Максимальное число {max}");