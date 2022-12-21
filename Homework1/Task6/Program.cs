// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)


using static System.Console;
Write("Введите число a: ");
int a = int.Parse(ReadLine()!);
if(a % 2 == 0)
{
    Console.WriteLine("Число является чётным.");
}
else
{
    Console.WriteLine("Число нечётное.");
}