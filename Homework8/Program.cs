//Домашнее задание к Семинару 8. 18.08.2022

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] GenerateRandom2DArray(int rows, int columns, int minValue, int maxValue)
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ArrayRowBubbleSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int n = 0;
        while (n < array.GetLength(1)) //каждую строку проверяем столько раз, сколько есть столбцов (правильно ли это?)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)//компенсируем "-1" то, что мы смотрим j+1 элемент, чтобы не выйти за границы массива.
            {                       
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
            n++;
        }
    }
    return array;
}

Console.Write("Введите количество строк массива: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение случайного элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение случайного элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] userArray = GenerateRandom2DArray(r, c, min, max);
Show2DArray(userArray);
int[,] sortedArray = ArrayRowBubbleSort(userArray);
Show2DArray(sortedArray);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GenerateRandom2DArray(int rows, int columns, int minValue, int maxValue)
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] CreateArrayOfRowSums (int[,] array)
{
    int[] sumsArray = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumsArray[i] = sum;
    }

    return sumsArray;
}

int FindIndexOfMinElement(int[] array)
{
    int minElementIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] <= array[minElementIndex]) minElementIndex = i; 
    }

    return minElementIndex;
}

Console.Write("Введите количество строк массива: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение случайного элемента: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение случайного элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] userArray = GenerateRandom2DArray(r, c, min, max);
Show2DArray(userArray);
int[] arrayOfSums = CreateArrayOfRowSums(userArray);
Console.WriteLine ($"Номер строки с минимальной суммой элементов = {FindIndexOfMinElement(arrayOfSums)+1}");

int[,] GenerateRandom2DArray(int rows, int columns, int minValue, int maxValue)
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Multipy2Matrices(int[,] arrayA, int[,] arrayB)
{
    int[,] multipliedArray = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            multipliedArray[i, j] = arrayA[i, j] * arrayB[i, j];
        }
    }

    return multipliedArray;
}

Console.Write("Введите количество строк для каждой из двух матриц: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для каждой из двух матриц: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение случайного элемента матрицы: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение случайного элемента: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] userArrayA = GenerateRandom2DArray(r, c, min, max);
Show2DArray(userArrayA);
int[,] userArrayB = GenerateRandom2DArray(r, c, min, max);
Show2DArray(userArrayB);
Console.WriteLine("Произвдение данных матриц выглядит так: ");
Show2DArray(Multipy2Matrices(userArrayA, userArrayB));

*/
//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2

int[,,] Generate3DArray(int page, int row, int column)
{
    int[,,] array3D = new int[page, row, column];
    for (int p = 0; p < array3D.GetLength(0); p++)
    {
        for (int r = 0; r < array3D.GetLength(1); r++)
        {
            for (int c = 0; c < array3D.GetLength(2); c++)
            {   
                int checkable = new Random().Next(10, 99);
                while (ElementExistence(array3D, checkable) == true) checkable = new Random().Next(10, 99);
                array3D[p, r, c] = checkable;
            }
        }
    }
    return array3D;
}

void Show3DArray(int[,,] array)
{
    for (int p = 0; p < array.GetLength(0); p++)
    {
        for (int r = 0; r < array.GetLength(1); r++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                Console.Write(array[p, r, c] + $" ({p}, {r}, {c})" + " ");
            }
            Console.WriteLine();
        }
    }
}

bool ElementExistence(int[,,] array, int element)
{
    int count = 0;
    for (int p = 0; p < array.GetLength(0); p++)
    {
        for (int r = 0; r < array.GetLength(1); r++)
        {
            for (int c = 0; c < array.GetLength(2); c++)
            {
                if (array[p, r, c] == element) count++;
            }
        }
    }
    if (count > 0) return true;
    else return false;
}

int[,,] my3DArray = Generate3DArray(2, 2, 2);
Show3DArray(my3DArray);





