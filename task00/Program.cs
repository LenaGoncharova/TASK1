// таблица умножения
using System;
using static System.Console;
Clear();

int[] CreateArr(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
        
    }
    return arr;
}
 int[] сreateArr=CreateArr(5,4,12);
 
WriteLine(String.Join(",",сreateArr));
 