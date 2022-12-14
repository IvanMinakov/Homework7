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

void FindNumber(int[,] array)

{ 
    int posx = 0;
    int posy = 0;
    bool check = false;
    System.Console.WriteLine("Введие искомое число");
    int number = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == number)
            {
                posy = i;
                posx = j;
                System.Console.WriteLine($"Положение в массиве элемента {number} находится в cтроке {posy + 1} и столбце {posx + 1} ");
                check = true;
            }
    if (check == false) System.Console.WriteLine("Такого числа в матрице нет");
}

System.Console.WriteLine("Введие количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введие количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
FindNumber(array);