//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

void FillArray(int [] array, int size)
{
    for(int i=0; i< size; i++)
{
    array[i] = new Random().Next(-50,999);
}
}
int DataEntry(string massage)
{
    Console.Write(massage);
    return Convert.ToInt32(Console.ReadLine());
}
int SumOfOddElements(int[] array)
{
    int result = 0;
    for (int i=0; i< array.Length; i +=2)
    {
        result += array[i];
    }
    return result;
}
int size= DataEntry("Введите размер массива ");
int [] numbers = new int [size];
FillArray(numbers, size);
System.Console.WriteLine("[{0}]", string.Join(",", numbers));
System.Console.Write("Сумма элементов, стоящих на нечетных позициях равна: ");
System.Console.WriteLine(SumOfOddElements(numbers));