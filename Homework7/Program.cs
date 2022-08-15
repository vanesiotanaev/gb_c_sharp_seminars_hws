// Домашнее задание к Семинару 7. 15.08.2022

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Create2DArrayReal(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(minValue, maxValue+1), 2);
        }
    }

    return newArray;
}

void Show2DArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int c = Convert.ToInt32(Console.ReadLine());

double[,] userArray = Create2DArrayReal(r, c, -100, 100);
Show2DArray(userArray);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Generate2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool ArrElementExist(int[,] array, int userRow, int userColumn)
{
    if (userRow < 0 || userColumn < 0 || userRow > array.GetLength(0) || userColumn > array.GetLength(1))
    {
        Console.WriteLine($"Элемента с индексами {userRow} и {userColumn} не существует в данном массиве!");
        return false;
    }
    else Console.WriteLine($"По индексам {userRow} и {userColumn} в данном массиве можно найти следующий элемент: {array[userRow, userColumn]}");
    return true;
}

Console.Write("Введите количество строк массива: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение случайного элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение случайного элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] userArray = Generate2DRandomArray(r, c, min, max);
Show2DArray(userArray);

Console.Write("Введите индекс столбца искомого элемента: ");
int ur = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс строки искомого элемента: ");
int uc = Convert.ToInt32(Console.ReadLine());

bool Existance = ArrElementExist(userArray, ur, uc);


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Generate2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageColumns(int[,] array)
{
    
    double avg = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        avg = sum / array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое элементов в {j+1} столбце данного массива равно: {avg}! ");
    }
}

Console.Write("Введите количество строк массива: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение случайного элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение случайного элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] userArray = Generate2DRandomArray(r, c, min, max);
Show2DArray(userArray);
AverageColumns(userArray);