//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]

//[6 7 3 6] -> [6 3 7 6]



using static System.Console;
Clear();

Write("Введите длину массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);
string stringArray = String.Join(",", array);
Write($"[{stringArray}]");
ResultArray1(array);
Write("  -->  ");
Write($"[{String.Join(",", array)}]");
//Write($"[{String.Join(",", ReversArray(array))}]");

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(1, 10);
    }
    return resultArray;
}
// int[] ReversArray(int[] InArray)
// {
//     int[] result = new int[InArray.Length];
//     for (int i = 0; i < InArray.Length; i++)
//     {
//         result[i] = InArray[InArray.Length - 1 - i];
//     }
//     return result;
// }

void  ResultArray1(int[] InArray)
{
    for (int i = 0; i < InArray.Length / 2; i++)
    {
        int temp = InArray[i];
        InArray[i] = InArray[InArray.Length - 1 - i];
        InArray[InArray.Length - 1 - i] = temp;
    }
}