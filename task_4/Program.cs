﻿//      Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//      5 -> 2, 4
//      8 -> 2, 4, 6, 8

Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int a = Int32.Parse(number);

int counter = 2;
while (counter < a)
{
  Console.Write($"{counter} ");
  counter = counter + 2;
}