// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях
// [3, 7, 23, 12] -> 19 // здесь суммируются только 1-я (7) и 3-я (12) поз-и, так как (3) явл. нулевой поз.
// [-4, -6, 89, 6] -> 0 // здесь суммируются только 1-я (-6) и 3-я (6) поз-и, так как (-4) явл. нулевой поз.


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}
int[] array = GetArray(5,-9,9);

void PrintArray(int[] arr)
{
    int unevenPosSum = 0;
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if (i % 2 > 0) unevenPosSum += arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {unevenPosSum} ");
    Console.WriteLine();
}

PrintArray(array);