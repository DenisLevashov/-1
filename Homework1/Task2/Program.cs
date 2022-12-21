//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

using static System.Console;

WriteLine("Введите число a ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите число b ");
int b = int.Parse(ReadLine()!);
int max = a;
if (a > b)
{

    WriteLine($"max = {max}");
}
else

    WriteLine($"max = {max = b} ");
