// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.
 Console.Clear();

//   int[] CopyArray(int[] massive)
//  {
//  int[] newArray = new int[massive.Length];
//  for (int i = 0; i < massive.Length; i++)
//  {
//  newArray[i] = massive[i];
//  }
//  return newArray;
//  }
//  void PrintArray(int[] array)
//  {
//  for (int i = 0; i < array.Length; i++)
//    {
//    Console.Write(array[i] );
//    }
//  }
//  int[] arr = { 5, 4, 6, 7 };
// int[] newarr = CopyArray(arr);
//  PrintArray(newarr); 



  int[]CopyArray(int[]arr)
  {
     int[]newarr= new int[ arr.Length];
     for (int i = 0; i <arr. Length; i++)   
    {
       newarr[i] = arr[i];
    }

      return newarr;
 }

 void PrintArr(int[]arr)
 { 
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
     {        if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]}");
     }
    
        Console.WriteLine("]");
}


  int [] massive={1,2,3, 4,5};
  PrintArr(massive);
   
  int[] сopyArray=CopyArray (massive);
  сopyArray[0]=55;//  демонстрация того что в скопированном массиве можно менять числа.
  PrintArr(сopyArray);