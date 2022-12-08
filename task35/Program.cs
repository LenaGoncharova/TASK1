// Задайте одномерный массив из 123 случайных чисел
// Найдите количество элементов массива, значения которых
// лежат в отрезке  [10,99].
using System;
using static System.Console;
Clear();
 int[] array= new int[10];

  void Elemets(int[]arr)
 {
   Random rnd=new Random();
   for (int i = 0; i < arr.Length; i++)
   {
     arr[i]= rnd.Next(0,300);
   }

 }

void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       Write( $" {arr[i]} ");
    }
    Write("]"); 
}

 int NumElem(int[]arr)
 {
    int elem=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >10 && arr[i]<100)
        elem++;
    }
     return elem;
 }

Elemets(array);
PrintArray(array);
int numElem = NumElem(array);
Write( $"количество элементов массива в отрезке  [10,99] ->{numElem}");