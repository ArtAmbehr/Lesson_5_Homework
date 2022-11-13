// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);        
    }
    return res;
}
int[] array = GetArray(8,100,1000);
Console.WriteLine();

void PrintResult(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;        
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество четных чисел {even}");
    System.Console.WriteLine();
}

PrintResult(array);



