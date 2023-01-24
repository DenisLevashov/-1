//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


using static System.Console;
Clear();

Write("Задайте первое значение: ");
double k1 = double.Parse(ReadLine());
Write("Задайте второе значение: ");
double b1 = double.Parse(ReadLine());
Write("Задайте третье значение: ");
double k2 = double.Parse(ReadLine());
Write("Задайте четвертое значение: ");
double b2 = double.Parse(ReadLine());



double x = 0;
double y = 0;

if(k1==k2)
{
    Write("Прямые параллельны");
}
else 
{
    x = (b2-b1)/(k1-k2);
    y = k2 * x + b2;
    WriteLine($"Точка пересечения двух прямых будет точка с координатами {x} {y} ");
}
    
   




