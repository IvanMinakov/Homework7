void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)

            array[i, j] = new Random().Next(1, 51);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        System.Console.WriteLine();
    }
}

void Average(int[,] array)
{
    double summ = 0; ;
    System.Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ += array[i, j];
        }
        System.Console.WriteLine($"Среднеарифметическое Столбца - {Math.Round(summ / array.GetLength(0)),3} ");
    }

}

System.Console.WriteLine("Введие количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введие количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
Average(array);
