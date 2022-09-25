//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int chetvert = int.Parse(Console.ReadLine());
if (chetvert==1) 
{
Console.WriteLine("x>0, y>0");
} else if (chetvert==2)
    {
    Console.WriteLine("x<0, y>0");
    } else if (chetvert==3) 
        {
        Console.WriteLine("x<0, y<0");
         }
         else 
         {
            Console.WriteLine("x>0, y<0");
         }