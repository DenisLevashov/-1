// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

//4; массив [6, 7, 19, 345, 3] -> нет

//3; массив [6, 7, 19, 345, 3] -> да

using static System.Console;
Clear();

WriteLine("Введите число:");
int number = int.Parse(ReadLine()!);

int [] array = {6, 7, 19, 345, 3};

WriteLine(ArrayLookUp(array, number)? "yes": "no");

bool ArrayLookUp(int[] InArray, int num)
{
    foreach (var i in InArray)
    {
        if ( num == i) return true;
    }
    return false;
}
