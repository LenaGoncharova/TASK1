// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждой строке.
Console.Clear();
int[,] MatrixArray(int line, int colums, int min, int max)
{
    int[,] matrix = new int[line, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4},");
            else Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine("|");
    }

}

double[] MiddleArifmetic(int[,] matrix)
{
    int size = matrix.GetLength(0);
    double[] result = new double[size];
     int ix= 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[ix] += matrix[i, j];
          
          result[ix] =Math.Round( (result[ix] / matrix.GetLength(0)),2);
          

        }

     ix++;

    }

    return result;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i], 2},  ");
        else Console.Write($"{arr[i],2}");
    }
    Console.WriteLine("]");
}

int[,] matrixArray = MatrixArray(2, 5, 1, 5);
PrintMatrix(matrixArray);
double[] middleArifmetic = MiddleArifmetic(matrixArray);

PrintArray(middleArifmetic);

 