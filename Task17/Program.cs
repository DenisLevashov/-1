//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

using static System.Console;

Clear();

Write("Задайте номер четверти: ");


bool isParse=int.TryParse(ReadLine(),out int i);
if(!isParse)
{
    WriteLine("Введено не число");
    return;
}

switch(i)
{
    case 1:
    {
        WriteLine("x>0,y>0");
        break;
    }
    case 2:
    {
        WriteLine("x<0,y>0");
        break;
    }
    case 3:
    {
        WriteLine("x<0,y<0");
        break;
    }
    case 4:
    {
        WriteLine("x>0,y<0");
        break;
    }
    default:
    {
        WriteLine("читай внимательно условие");
        break;
    }

    
}

// if(i==1)
// {
//     WriteLine("x>0,y>0");
// }
// if(i==2)
// {
//     WriteLine("x<0,y>0");
// }
// if(i==3)
// {
//     WriteLine("x<0,y<0");
// }
// if(i==4)
// {
//     WriteLine("x>0,y<0");
// }
// if(i>4 || i<1)
// {
//     WriteLine("читай внимательно условие");
// }