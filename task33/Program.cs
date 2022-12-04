// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
 
Console.Clear();
Console.Write("Введите целое число: ");
int x= Convert.ToInt32(Console.ReadLine());
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

bool FindNum(int[]arr,int find)
{
  for (int i = 0; i <arr.Length; i++)
  {
     if (arr[i]==find) return true;
  }
  return false;
}
int[]array=CreateArr(9,-10,12);
bool resalt= FindNum(array,x);

PrintArray(array);

Console.Write($"{x}");

Console.WriteLine (resalt ?"->Да":" ->Нет");
