// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = GetArray(4, 10, 99);
Console.WriteLine(String.Join(" ", array));
int result = SumOddElements(array);
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");


int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1); 
    }
    return res;
}

int SumOddElements(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
        result += array[i];
        }
    }
    return result;
}




