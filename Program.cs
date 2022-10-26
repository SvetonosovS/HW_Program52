// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[] average = ArithmeticColumn(array);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", average)}");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

static double[] ArithmeticColumn(int[,] array)
{
    double[] ArithmeticArray = new double[array.GetLength(1)];
    for (int j = 0; j < ArithmeticArray.Length; j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            ArithmeticArray[j] += array[i, j];
        }
    ArithmeticArray[j] = Math.Round(ArithmeticArray[j] / array.GetLength(0), 1);
    }
    return ArithmeticArray;
}
