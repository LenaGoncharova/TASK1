//  Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
Console.Clear();
//    метод находящий позицию минимального элемента\
int[] FindPositionMinElement(int[,] mass)
{
int[] array = new int[2];
int min=mass[0,0];
for (int i = 0; i < mass.GetLength(0); i++)
{
for (int j = 0; j < mass.GetLength(1); j++)
{
if(mass[i,j]<min)
{
min=mass[i,j];
array[0]=i;
array[1]=j;
}
}
}
return array;
}
//  метод убирающий строку и столбец с минимальным элементом 
int[,] CreateMatrix(int[,] matrix, int[] index)
{
int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
int m = 0;
int n = 0;
for (int i = 0; i < newMatrix.GetLength(0); i++) //2
{
if (m == index[0]) m++;

for (int j = 0; j < newMatrix.GetLength(1); j++)
{

if (n == index[1]) n++;
newMatrix[i, j] = matrix[m, n];
n++;
}
n = 0;
m++;
}
return newMatrix;
}