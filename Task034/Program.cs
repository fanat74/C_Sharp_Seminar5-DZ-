// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int sizearray=Convert.ToInt32(Console.ReadLine());

int [] FillArray (int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for( int i=0; i<size; i++)
    {
        arr[i]= rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[]arr)
{
    Console.Write("[");
    for (int i=0; i<arr.Length; i++)
    {
        if(i<arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int EvenNumbers(int []arr)
{
    int count=0;
    for (int i=0; i<arr.Length; i++)
    {
        if(arr[i]%2==0) 
        {
            count+=1;
        }
    }
    return count;
}

int[] array = FillArray(sizearray, 100, 999);
PrintArray(array);
int evenNumbers = EvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве равно {evenNumbers}");