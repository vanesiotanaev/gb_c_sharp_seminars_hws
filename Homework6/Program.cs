// Домашнее задание к Семинару 6.

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountPositive(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i+1}е число: ");
        int value = Convert.ToInt32(Console.ReadLine());
        if (value > 0) count++;
    }

    return count;
}

Console.Write("Введите количество чисел: ");
int userM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество положительных чисел из {userM} введенных: {CountPositive(userM)}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

string IntersectionPoint(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    string result = $"({x}; {y})";

    return result;
}

Console.Write("Введите k1: ");
double userk1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double userk2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double userb1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double userb2 = Convert.ToDouble(Console.ReadLine());

string intersect = IntersectionPoint(userk1, userk2, userb1, userb2);
Console.WriteLine($"Точка пересечения прямых y = {userk1}x + {userb1} и y = {userk2}x + {userb2}: {intersect}");