// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите три числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b>max) max = b;
if (c>max) max = c;

Console.Write("Максимальное число равно: ");
Console.WriteLine(max);