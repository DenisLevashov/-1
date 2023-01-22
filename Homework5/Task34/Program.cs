// Напишите программу реализующую методы формирования массива, 
//заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using static System.Console;
Clear();

int [] array = new int[8];
int sum = 0;

void EventArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0)
        sum+=1;
    }
    WriteLine($"количесвто четных чисел в массиве равно  {sum}");
}

int[] CreateArray()
{
    
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.Write("[");

    for (int i = 0; i < array.Length-1; ++i)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
    return array;
}

EventArray(CreateArray());