// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();

int[]NewArr(int size, int num, int num1)
{
  int[]array=new int[size];
  Random rnd=new Random();
  for (int i = 0; i <size; i++)
  {
    array[i]= rnd.Next(num,num1);
  }
  return array;
}

void PrintArr(int[]arr)
{
    Console.Write("[");
    for (int i = 0; i <arr. Length; i++)
    {
     if(arr[i]<arr.Length-1) Console.Write( $"{arr[i]}, ");
     else Console.Write( $"{arr[i]}");
    }
    Console.WriteLine("]");
}
     void ReplaceNum(int[] arr)     //  метод   void , потому что мы не создаем массив а переделываем    
{
    for (int i = 0; i <arr.Length; i++)
    {
      arr[i]=arr[i]* -1;
    }


}

int[]newArr=NewArr(12,-10,10) ;
PrintArr(newArr );

ReplaceNum(newArr);

PrintArr(newArr);