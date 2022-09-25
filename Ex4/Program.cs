// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
Console.Clear();

Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
int i=1;
for (i=1;i<n+1;i++)
{
    int sqr=i*i;
    Console.Write($" {sqr}");
}