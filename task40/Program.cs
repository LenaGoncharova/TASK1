// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
Console.Clear();

bool Triangle( int num1, int num2,int num3)
{
  return num1+num2>num3&&num2+num3 >num1&&num1+num3>num2;
}

bool resalt=Triangle( 2,4,5);
Console.WriteLine( resalt? "Да" :"Нет");