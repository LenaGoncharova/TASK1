// Найдите произведение пар чисел в одномерном массиве
// Парой считается первый и последний элемент, второй и предпослдений итд.
// Результат запишите в новом массиве.



int[]NewArr(int size,int min,int max)
{
  int [] arr= new int[size];
  Random rnd=new Random();
  for (int i = 0; i < size; i++)
  {
    arr[i]= rnd.Next( min,max+1);
  }
  return arr;
}

void PrintArr(int[]arr)
{ 
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
       if (i<arr.Length-1) Console.Write($"{arr[i]}, ");
       else Console.Write($"{arr[i]}");
    }
    
        Console.WriteLine("]");
}

int[] MuitArr(int[]arr)
{
 int size=arr.Length/2;
 if (arr.Length%2==1)size=size+1;
 int []numArr=new int[size];
 for (int i = 0; i < size; i++)
 {
    numArr[i]=arr[i]*arr[arr.Length-1-i];
 }
 if(arr.Length%2==1) numArr[size-1]=arr[size-1]; // или if(arr.Length%2==1) numArr[size-1]=arr[arr.Length/2]; 
 
  return numArr;
}

    int[]newArr=NewArr(5,1,6);
     PrintArr(newArr);

     int[]muitArr=MuitArr(newArr);
     PrintArr(muitArr);
