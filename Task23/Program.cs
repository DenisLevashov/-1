//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120




using static System.Console;
Clear();

Write("Введите число: " );
int number=int.Parse(ReadLine()!);
int sum=NumCount(number);
WriteLine($"Произведение чисел от 1 до {number} будет равно {sum}");

int NumCount(int N)
{
    if(N<=0) return 0;
     
    int result=1;
    while(N>0)
    {
        result=result*N;
        N=N-1;
    }
    return result;
}