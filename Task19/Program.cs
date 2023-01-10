// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

using static System.Console;

Clear();

Write("Задайте координаты точки A, по оси X: ");
int.TryParse(ReadLine(),out int Ax);
Write("Задайте координаты точки A, по оси Y: ");
int.TryParse(ReadLine(),out int Ay);
Write("Задайте координаты точки B, по оси X: ");
int.TryParse(ReadLine(),out int Bx);
Write("Задайте координаты точки B, по оси Y: ");
int.TryParse(ReadLine(),out int By);

double pif = Math.Sqrt((Bx - Ax)*(Bx - Ax) + (By - Ay)*(By - Ay));
double result = pif;
WriteLine(result);