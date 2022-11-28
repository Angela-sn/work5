// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
double[] array = GetArray(5, 10, 99);
Console.WriteLine(String.Join(" ", array));

double differenceMax = MaxDifference(array);
double differenceMin = MinDifference(array);
double result = differenceMax - differenceMin;
Console.Write($"Разницу между максимальным и минимальным элементами массива -> {Math.Round(result, 2)}");

double[] GetArray (int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return res;
}

double MaxDifference(double[] array)
{
    double maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
    }
    return maxNumber;
}

double MinDifference(double[] array)
{
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
    }
    return minNumber;
}
