// Напишите программу реализующую методы формирования массива, 
//заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


using static System.Console;
Clear();

int[] array = new int[8];
int sum = 0;

int[] RandomArray()
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    Console.Write("[");

    for (int i = 0; i < array.Length - 1; ++i)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
    return array;
}

void CountArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2==0);
        else
        {
            sum+=array[i];
        }
    }   
        WriteLine($"сумма элементов, стоящих на нечётных позициях будет равна {sum}");
    

}
CountArray(RandomArray());