// See Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
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


void Print2DArray(int[,] array)
{

for (int i = 0; i < array.GetLength(0); i++)

{
     Console.Write("|");
    for (int j = 0; j <array.GetLength (1); j++)
    {
        if(j < array.GetLength(1) - 1) Console.Write($"{array[i,j],2} ");
        // ($"{array[i,j],2} ")- 2 показывает количество пробелов между цифрами для лучшей читабельности.
        else Console.Write($"{array[i,j],2} ");
    }
    Console.WriteLine("|");
}

}

int[,] matrix2D=CreateMatrixRndInt (3, 4, 0,100);
Print2DArray(matrix2D);

// void Print2DArray(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// Console.Write("|");
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
// else Console.Write($"{matrix[i, j], 4} ");
// }
// Console.WriteLine("|");
// }
// }
// int[,] matrix2D=CreateMatrixRndInt (3, 4, 0,100);
// Print2DArray(matrix2D);