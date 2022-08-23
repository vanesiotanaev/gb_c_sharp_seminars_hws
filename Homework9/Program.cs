//Домашнее задание к Семинару 9. 23.08.2022
//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNumbers(int m, int n)
{
    Console.Write(m + " ");

    if (m < n) ShowNumbers(m+1, n);
    if (m > n) ShowNumbers(m-1, n);
}

ShowNumbers(1, 7);

Console.WriteLine();

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumValues(int m, int n)
{
    if (m < n) return m + SumValues(m+1, n);
    if (m > n) return m + SumValues(m-1, n);

    return n;
}

Console.WriteLine(SumValues(5, 0));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0) return n+1;
    if (m > 0 && n == 0) return Akkerman(m-1, 1);
    if (m > 0 && n > 0) return Akkerman(m-1, Akkerman(m, n-1));

    return 0;
}

Console.WriteLine(Akkerman(3, 0));