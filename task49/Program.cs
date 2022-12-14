// //Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

Console.Clear();
 
 int[,] MatrixArr ( int rows,int tab,int min ,int max)
 {
   int [,]newMatArr= new int[ rows, tab];
   Random rnd=new Random();
   for (int i = 0; i <newMatArr.GetLongLength(0); i++)
   {
    for (int j = 0; j < newMatArr.GetLength(1); j++)
    {
      newMatArr[i,j] =rnd.Next( min,max+1) ;
    }
   }
   return newMatArr;
 }

  void Print2DArray( int [,] arr)
  { 
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1);j ++)
        {
            Console.Write($"{arr[i,j],4},");
        }
        Console.WriteLine("|");
    }


  }
 

 void QartMatr(int[,] arr)
 {
    for (int i = 0; i <arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength (1); j++)
        {
            if (i%2==0 && j%2==0) arr[i,j]*=arr[i,j];
        }
        
    }

 }

int[,] matrixArr=  MatrixArr( 5,6, 0,10);
 Print2DArray(matrixArr);
 Console.WriteLine();
 QartMatr(matrixArr);
 Print2DArray(matrixArr);
