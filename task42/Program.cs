// : Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Clear();

Console.WriteLine("введите число- ");
int f= Convert.ToInt32(Console.ReadLine());

// 1 вариант строчный 
 string BinaryCod( int f)
 {
 string res = string. Empty;
  while( f>0)
  {
     res= f%2 + res;
      f=f/2;
  }
   return res;
 }

 Console.WriteLine(BinaryCod(f));
// 2 вариант с использованием массива и дальнейшем его разворотом с помощью встроенной функции
int[] BinaryCode( int f)
{
   int a=f;
  int count=0;
  while (f>0)
  { 
     f=f/2;
     count=count+1;

  }
    int[]arr1=new int[ count];
    for (int i = 0; i < count ; i++)
    {
      arr1[i]= a%2;
      a=a/2;
      
    }
     return arr1;
}

void PrintArr(int[]arr)
{ 
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
      Console.Write($"{arr[i]}");
    }
    
        Console.WriteLine("]");
}

int[]binaryCode= BinaryCode(f);
Array.Reverse(binaryCode);
 PrintArr(binaryCode);
  
//  3 вариант сразу  делаем массив, но начинаем его с конца,те разворот не нужен.
 int[] BinaryCoda(int f)
 {
 int a = f;
 int count = 0;
 while (f > 0)
 {
f = f / 2;
 count++;
}
 int[] arr = new int[count];
 for (int i = count-1; i>0 ; i--)
 {
 arr[i] = a % 2;
 a = a / 2;
 }
 return arr;
}

int[]binaryCoda= BinaryCoda(f);
 PrintArr(binaryCoda);