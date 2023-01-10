//  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//      выдаёт номер четверти плоскости, в которой находится эта точка

using static System.Console;

Clear();

Write("Задайте координаты точки X: ");
int x = int.Parse(ReadLine()!);
Write("Задайте координаты точки Y: ");
int y = int.Parse(ReadLine()!);

if (x == 0 || y == 0)
{
    WriteLine("ошибка");
    return;
} 
if (x > 0 && y > 0)
{
    WriteLine("1");
}
if (x < 0 && y > 0)
{
    WriteLine("2");
}
if (x < 0 && y < 0)
{
    WriteLine("3");
}
if (x > 0 && y < 0)
{
    WriteLine("4");
}