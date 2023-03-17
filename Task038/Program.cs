// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите размер массива");
int sizearray=Convert.ToInt32(Console.ReadLine());

double [] FillArray (int size)
{
    double [] arr = new double [size];
    Random rnd = new Random();
    for( int i=0; i<size; i++)
    {
        arr[i]= rnd.NextDouble()*100;
    }
    return arr;
}

void PrintArray(double[]arr)
{
    Console.Write("[");
    for (int i=0; i<arr.Length; i++)
    {
        if(i<arr.Length-1) Console.Write($"{Math.Round(arr[i], 2)}, ");
        else Console.Write($"{Math.Round(arr[i], 2)}");
    }
    Console.WriteLine("]");
}

double DiffMaxMinNumbers(double []arr)
{
    double max=0;
    double min=0;
    for (int i=0; i<arr.Length; i++)
    {
        if(arr[i]>max) 
        {
            max=arr[i];
        }
        if(arr[i]<min) 
        {
            min=arr[i];
        }
    }
    double difference = Math.Round((max-min), 2);
    return difference;
}

double[] array = FillArray(sizearray);
PrintArray(array);
double diff = DiffMaxMinNumbers(array);
Console.WriteLine($"Разность чисел равна {diff}");