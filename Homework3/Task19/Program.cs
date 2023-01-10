// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
using static System.Console;
Clear();
Write("Введите пятизначное число: ");
int number = int.Parse(ReadLine()!);

int num1 = number / 10000;
int num2 = number / 1000 % 10;
int num4 = number / 10 % 10;
int num5 = number % 10;

if(num1 == num5 && num2 == num4)
{
    WriteLine("Число ЯВЛЯЕТСЯ ПАЛИНДРОМОМ!");
}
else
{
    WriteLine("Число НЕ ЯВЛЯЕТСЯ ПАЛИНДРОМОМ!");
}