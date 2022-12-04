// // Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
Console.Clear();
// int GetSumPositiveElem(int[] array)
// {
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// if(array[i] > 0) sum += array[i]; // sum = sum + array[i];
// return sum;
// }

// int GetSumNegativeElem(int[] array)
// {
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
// if(array[i] < 0) sum += array[i]; // sum = sum + array[i];
// return sum;
// }

// int[] arr = CreateArrayRndInt(12, -9, 9);
// PrintArray(arr);
// int sumPositive = GetSumPositiveElem(arr);
// int sumNegative = GetSumNegativeElem(arr);
// Console.WriteLine($"Сумма положительных чисел = {sumPositive}");
// Console.WriteLine($"Сумма отрицательных чисел = {sumNegative}");


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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i <arr.Length; i++)
    {
       if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
} 

int PositivSum(int[] arr)
{ int sum =0;
  for (int i = 0; i <  arr.Length; i++)
  {
    if (arr[i]>0) sum+=arr[i]; // if (arr[i]>0) sum= sum+arr[i];    
  }
  return sum;
}

int NegativeSum(int[] arr)
{ int sum =0;
  for (int i = 0; i <  arr.Length; i++)
  {
    if (arr[i]<0) sum+=arr[i];
  }
  return sum;
}

 int[]createArr =  CreateArr(12,-9,9);
 PrintArray (createArr);
int positivSum = PositivSum(createArr );
Console.WriteLine($"Сумма положительный чисел = {positivSum}");
int negativeSum = NegativeSum(createArr ); 
Console.WriteLine($"Сумма отрицательный  чисел = {negativeSum}");