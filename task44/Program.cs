// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.Clear();
 int[]Fibonachi(int n , int num1, int num2)
 {
  int[]arr= new int[n];
  num1=0;
  num2=1;

  for (int i = 2; i < n; i++)
  {
    arr[0]=num1;
    arr[1]= num2;
    arr[i]= arr[i-1]+arr[i-2] ;


  }
   return arr;
 }
  
  void PrintArr(int[]arr)
{ 
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
      Console.Write($"{arr[i]},");
    }
    
        Console.WriteLine("]");
}

int[]fibonachi=Fibonachi( 10,0,1);
PrintArr( fibonachi);