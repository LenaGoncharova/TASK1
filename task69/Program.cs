﻿// : Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
Console.Clear();
Console.Write("Введите число А: ");
int a=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень B: ");
int b=Convert.ToInt32(Console.ReadLine());


int Power( int num1,int num2)
{
  if(num2==0) return 1;
   return num1*Power( num1,num2-1);
   
}
int power= Power( a,b);
Console.WriteLine( power);