// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли 
// число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число:");
double x = Convert.ToInt32(Console.ReadLine());
if (x % 2 == 0)
    Console.WriteLine("Число является ЧЕТНЫМ");
else
    Console.WriteLine("Число является НЕчетным");