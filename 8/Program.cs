﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое положительное число : ");
int num = Convert.ToInt32(Console.ReadLine());
for ( int i = 2; i <= num; i = i + 2 )
   {
    Console.Write($"{i}, " );
    }  