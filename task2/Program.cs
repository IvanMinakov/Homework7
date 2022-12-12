void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)

            array[i, j] = new Random().Next(1, 51);
}

void PrintArray(int[,] array)
{
    int check = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        System.Console.WriteLine();
        if (array[i] == check) System.Console.WriteLine($"Число {check} находится в матрице");
        else System.Console.WriteLine("Такого числа в матрице нет");
    }
}

System.Console.WriteLine("Введие количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введие количесво столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Введите число для проверки");
int check = Convert.ToInt32(Console.ReadLine());
