//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[]  FillArray (int size)
{
 int[] numbers = new int [size];
 for(int i=0; i< numbers.Length; i++)
 {
    numbers[i] = new Random().Next(100,999);
 }
  
return numbers;
}
int CountMultipli(int[] array)
{
    int count =0;
    for (int i=0; i< array.Length; i++)
    {
        if(array[i]%2==0)
        {
            count++;
        }
    }
    return count;
}
int size =10;
int [] numbers = FillArray(size);
System.Console.WriteLine("[{0}]", string.Join(",", numbers));
System.Console.Write("В массиве четных чисел:");
System.Console.WriteLine(CountMultipli(numbers));