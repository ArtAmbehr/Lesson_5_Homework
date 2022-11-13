// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

void PrintMinMaxDif(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    int difference = array.Max() - array.Min();
    Console.WriteLine();
    Console.WriteLine($"Мин.значение равно {array.Min()}, макс.значение равно {array.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным элементами массива равна {difference}");
}
PrintMinMaxDif(array);
Console.WriteLine();