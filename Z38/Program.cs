//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
// элементов массива.

int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(float[] array)
{
    for (int i=0; i< array.Length; i ++)
    {
        array[i]= new Random().Next(1,100);
    }
}
float Difference (float[] array)
{
    float max = array[0];
    float min = array[0];
    for (int i=1; i< array.Length; i ++)
    {
        
        if(array[i]> max)
        {
            max= array[i];
        }
        if(array[i]<min)
        {
            min= array[i];
        }
    }
    return max-min;
}
int size= DataEntry("Введите размер массива ");
float[] numbers= new float[size];
FillArray(numbers);
System.Console.WriteLine("[{0}]", string.Join(",", numbers));
System.Console.Write("Разница между максимальным и минимальным значением массива равна: ");
System.Console.WriteLine(Difference(numbers));