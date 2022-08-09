//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] GenerateRandomArrayMethod(int size, int minValue, int maxValue)
{
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++) newArr[i] = new Random().Next(minValue, maxValue + 1);

    return newArr;
}

void ShowArrayMethod(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

   Console.WriteLine();
}

int ShowEvenValuesMethod (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count; 
}

Console.Write("Введите желаемый размер массива: ");
int prefsize = Convert.ToInt32(Console.ReadLine());
int[] userarr = GenerateRandomArrayMethod(prefsize, 100, 999);
ShowArrayMethod(userarr);
int evenquant = ShowEvenValuesMethod(userarr);
Console.Write($"Количество четных элементов в массиве: {evenquant}");


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GenerateRandomArrayMethod(int size, int minValue, int maxValue)
{
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++) newArr[i] = new Random().Next(minValue, maxValue + 1);

    return newArr;
}

void ShowArrayMethod(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

   Console.WriteLine();
}

int OddPositionsSumMethod(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.Write("Введите желаемый размер массива: ");
int prefsize = Convert.ToInt32(Console.ReadLine());
int[] userarr = GenerateRandomArrayMethod(prefsize, -999, 999);
ShowArrayMethod(userarr);
int oddsum = OddPositionsSumMethod(userarr);
Console.Write($"Сумма элементов, стоящих на нечетных позициях в массиве = {oddsum} !");

*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] UserArrayMethod()
{
    Console.WriteLine();
    Console.Write("Введите размер массива (желаемое количество элементов): ");
    int userq = Convert.ToInt32(Console.ReadLine());
    
    double[] array = new double[userq];

    for (int count = 0; count < userq; count++)
    {
        Console.Write($"Введите {count+1}й элемент массива: ");
        array[count] = Convert.ToDouble(Console.ReadLine());
    }

    return array;
}

void ShowArrayMethod(double[] array)
{
   for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

   Console.WriteLine();
}


double MinMaxDiffMethod(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= min) min = array[i];
    }
    
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max) max = array[i];
    }

    double diff = max - min;
    
    return diff;
}

double[] userarr = UserArrayMethod();
ShowArrayMethod(userarr);

double difference = MinMaxDiffMethod(userarr);
Console.WriteLine($"Разница между минимальным и максимальным элементами массива: {difference}");