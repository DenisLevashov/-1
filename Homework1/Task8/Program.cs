// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N


using static System.Console;
Write("Введите положительное число: ");
int a = int.Parse(ReadLine()!);
int count = 2;
while(count <= a)
{
    Write(count + " ");
    count = count + 2;
}
