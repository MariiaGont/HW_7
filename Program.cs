// Задача 47. Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void Task47()
{
    Console.WriteLine("Программа задаёт двумерный массив размером m*n, заполненный случайными вещественными числами,");
    Console.WriteLine("округлёнными до одного знака. Задайте размер двумерного массива.");
    Console.Write("m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    double[,] numbers = new double[m, n];
    FillArrayDecimals(numbers);
    PrintArrayDecimals(numbers);
    Console.WriteLine("\n");
}

// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 3 -> 3
void Task50()
{
    Console.WriteLine("Программа принимает на вход индексы элемента в двумерном массиве, и возвращает значение этого элемента.");
    Console.Write("Введите значение первого индекса: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение второго индекса: ");
    int j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int rows = 5;
    int columns = 7;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    if (i >= 0 && i < rows &&
        j >= 0 && j < columns)
    {
        Console.WriteLine($"Элемент с индексами ({i}, {j}) равен {numbers[i, j]}.");
    }
    else Console.WriteLine($"Элемент с заданными индексами ({i}, {j}) не существует в данном массиве.");
    Console.WriteLine("\n");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце. Например, задан массив:
// 1 4 7 2
// 5 9 5 3
// 8 4 6 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.
void Task52()
{
    Console.WriteLine("Программа находит среднее арифметическое элементов в каждом столбце заданного массива.");
    Console.WriteLine();
    int rows = 4;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Вывод элементов каждого столбца массива и их среднего арифметического.");
    for (int i = 0; i < rows; i++)
    {
        double sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += numbers[j, i];
            Console.Write($"({numbers[j, i]}) - "); 

        }
        double result = sum / rows;
        Console.Write($"> {result}.");
        Console.WriteLine();
    }
}

void FillArrayDecimals(double[,] numbers)
{
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round(rand.NextDouble() * 30 - 10, 1); 
        }
    }
}
void PrintArrayDecimals(double[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Console.WriteLine("Вывод двумерного массива:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] numbers, int minValue = -10, int maxValue = 10)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
        }
    }

}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Console.WriteLine("Вывод двумерного массива:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Task47();
Task50();
Task52();