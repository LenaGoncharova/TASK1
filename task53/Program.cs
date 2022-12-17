// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.


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
void ReplaceArray( int [,] arr )
{


 for (int i = 0; i <arr.GetLength(1);i++)  
//   важно!! i <arr.GetLength(1), а не i <arr.GetLength(0)
 {
     int count= arr[0,i];
     arr[0,i]= arr[arr.GetLength(0)-1 ,i];
     arr[arr.GetLength(0)-1 ,i]= count;
      
 }
  
}



int[,] array2D = CreateMatrixRndInt(4, 5,1,8);
PrintMatrix(array2D);
 Console.WriteLine();
 ReplaceArray(array2D );
PrintMatrix( array2D);