// Напишите программу реализующую методы формирования массива, 
//заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.
//[3,3 7,1 22,5 2,2 78,2] -> 76


using static System.Console;
Clear();

int[] array = new int[8];


int result = 0;


int[] RandomArray()
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    Write("[");

    for (int i = 0; i < array.Length - 1; ++i)
    {
        Write(array[i] + ", ");
    }
    WriteLine(array[array.Length - 1] + "]");
    return array;
}

void DifferenceArray(int[]array)
{   
    int max=array[0];
    int min=array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if (max<array[i]) max=array[i];
        if (min>array[i]) min=array[i];
        
    }
    WriteLine($"разница между максимальным {max} и минимальным {min} элементов массива будет равна {result=max-min}");
}
DifferenceArray(RandomArray());