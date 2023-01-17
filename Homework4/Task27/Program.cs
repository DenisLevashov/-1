//Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

using static System.Console;
Clear();

WriteLine("Введите любое чило: ");
int n = int.Parse(ReadLine()!);

int sum = 0;
while (n > 0)
{
    sum = sum + n % 10;
    n = n / 10;
}
WriteLine($"Сумма цифр в числе равна {sum}");