////Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
using static System.Console;
Clear();

WriteLine("Введите целые числа через ПРОБЕЛ");
int[] array = Array.ConvertAll(ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries), int.Parse);
int count =0;
int[] CreateArray()
{
    
    
    Write("[");

    for (int i = 0; i < array.Length-1; ++i)
    {
        Write(array[i] + ", ");
    }
    WriteLine(array[array.Length - 1] + "]");
    return array;
}

void PositiveNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) count++;
    }
    WriteLine($"Пользователь ввел {count} чисел больше нуля");
}
PositiveNumbers(CreateArray());