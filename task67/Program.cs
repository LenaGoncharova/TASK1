// //  Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Clear();
Console.Write("введите целое число: ");
int m= Convert.ToInt32(Console.ReadLine());

int SummNumbers( int num)
{
   if(num==0) return 0;
    return num%10+  SummNumbers( num/10);


}
int res= SummNumbers(m);
Console.WriteLine( res);