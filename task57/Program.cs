//  Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// 1  метод 
//  переделываем двухмерный массив в одномерный.
//  2 метод 
//  одномерный массив сортируем по нарастанию.
//  3  метод 
// считающий количестов одинаковых элементов в одномерном массиве.
Console.Clear();

Console.Clear();
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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


void Print2DArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)

    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],2} ");
            // ($"{array[i,j],2} ")- 2 показывает количество пробелов между цифрами для лучшей читабельности.
            else Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine("|");
    }

}
//  метод перевода двухмерного массива в одномерный!
int[] ReplaceArr(int[,] arr)
{
    int[] replaceArr = new int[arr.GetLength(0) * arr.GetLength(1)];
    int inx = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            replaceArr[inx] = arr[i, j];
            inx++;
        }
    }
    return replaceArr;

}

void PrintArray(int[] arr)
{
    Console.Write("|");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i],2},  ");
        else Console.Write($"{arr[i],2}");
    }
    Console.WriteLine("|");
}
//  1  метод 
// считающий количестов одинаковых элементов в одномерном массиве.
// void PrintResult(int[] arr)
// {
//     int count = 1;
//     int num = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] == num) count++;
//         else
//         {
//             Console.WriteLine($"{num} встречается {count} раз");
//             num = arr[i];
//             count = 1;
//         }
//     }
//     Console.WriteLine($"{num} встречается {count} раз");
// }
//  2 метод метод 
// считающий количестов одинаковых элементов в одномерном массиве.
void PrintResult(int[] arr)
{
    int num = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (num != arr[i])
        { 
            Console.WriteLine($" {num} встречается {count} раз ");
           num = arr[i];
            count=1;
       }
        else count++;
    }
    Console.WriteLine($" {num} встречается {count} раз ");
    

}

int[,] matrix2D = CreateMatrixRndInt(3, 3, 0, 7);
Print2DArray(matrix2D);
int[] replaceArr = ReplaceArr(matrix2D);
PrintArray(replaceArr);
Array.Sort(replaceArr);//  Array.Sort(replaceArr)- встроенный метод сортирующий массив.       
PrintArray(replaceArr);
PrintResult(replaceArr);