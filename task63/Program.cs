//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
Console.Clear();
 Console.Write("Введите натуральное число N: ");
 int n=Convert.ToInt32(Console.ReadLine());
//  1 способ с использованием return 
//  void NaturalNumber( int number)
//  {
//     if(number==0) return ;
//     NaturalNumber( number-1);
//     Console.Write($"{number}  ");
//  }
//  2 способ
 void NaturalNumber( int number)
 {
    if(number>0)
    { NaturalNumber( number-1);
    Console.Write($"{number}  ");
    }
 }

    
 NaturalNumber(n);
 Console.WriteLine();
  NaturalNumber(n);