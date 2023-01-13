//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5



using static System.Console;
Clear();

Write("Введите число: " );
int number=int.Parse(ReadLine()!);
int sum=NumCount(number);
WriteLine($"Количество цифр в числе {number} равно {sum}");

int NumCount(int num)
{
    int result=0;
    while(num>0)
    {
        result=result+1;
        num=num/10;
    }
    return result;
}