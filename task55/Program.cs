﻿// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
Console.Clear();
int[,]CreateMatrixRndInt(int line, int columns,int min,int max)
{
int[,] matrix = new int[line, columns];
 Random rnd= new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] =rnd.Next( min,max);
}
}
return matrix;
}
void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (matrix[i, j] < 10) Console.Write($"{matrix[i, j],3}");
else Console.Write($"{matrix[i, j],3}");
}
Console.WriteLine("|");
}
}
// int[,] ReplaceLineColoms( int [,] arr )
// {
//     int[,]replaceArr= new int[arr.GetLength(0),arr.GetLength(1)];
//  for (int i = 0; i <arr.GetLength(0);i++)  
//  {
//    for (int j = 0; j <arr.GetLength(1) ; j++)
//    {

//      replaceArr[i,j]= arr[j ,i];
     
//    }
     
//  }
//    return replaceArr;
// }
// Второй метод 
void ReplaceLineColoms( int [,] arr )
{
 for (int i = 0; i <arr.GetLength(0);i++)  
 {
   for (int j = i; j <arr.GetLength(1) ; j++)
   {

     int count=arr[j,i];
     arr[j,i]=arr[i,j];
     arr[i,j]=count;
   }
     
 }
   
}



int[,] array2D = CreateMatrixRndInt(5, 5,1,8);
PrintMatrix(array2D);
 Console.WriteLine();
 if  (array2D.GetLength(0)==array2D.GetLength(1))
 {
//     int[,] replaceLineColoms =ReplaceLineColoms( array2D );
//    PrintMatrix( replaceLineColoms);
//   }
ReplaceLineColoms(array2D);
PrintMatrix(array2D);
 }
  else Console.WriteLine( "это не квадрат");