// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
 Console.Clear();
int[,] CreateMatrixRndInt (int rows, int columns, int min,int max)
{
int[,] matrix = new int[rows, columns];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = rnd.Next(min, max + 1);
    }

}
return  matrix;
}
void PrintMatrix( int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j<arr.GetLength(1)-1)Console.Write($"{arr[i,j],3},");
            else Console.Write($"{arr[i,j],3}");
        }
        Console.WriteLine("|");
    }

}

// void Matrix2D2(int [,]arr)
//   { 
//     for (int i = 0; i <arr.GetLength(0) ; i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         if(i==j) arr[i,j]+=arr[i,j];
//     }
//     {
     

//   }
//   }


int SumIndex (int[,]matrix)
{
int sum = 0;
for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
{
sum += matrix[i, i];
}
return sum;
}



int[,] matrix2D= CreateMatrixRndInt( 5,4, 1,5);
PrintMatrix(matrix2D );
Console.WriteLine();
int res =SumIndex(matrix2D);
Console.WriteLine(res);
