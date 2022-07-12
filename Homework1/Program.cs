//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int num1, num2;

Console.Write("Please, enter the first number :");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter the second number :");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your numbers are: " + num1 + ", " + num2);

if (num1 != num2)
{
    if (num1 > num2) Console.WriteLine("The biggest number is " + num1 + ". The smallest is " + num2);
    else Console.WriteLine("The biggest number is " + num2 + ". The smallest is " + num1);
}
else
{
    Console.WriteLine("These numbers are equal");
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int num1, num2, num3, max1, max2;

Console.Write("Please, enter the first number :");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter the second number :");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter the third number :");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2) max1 = num1;
else max1 = num2;
if (num2 >= num3) max2 = num2;
else max2 = num3;
if (max1 >= max2) Console.WriteLine ("The biggest number is " + max1);
else Console.WriteLine ("The biggest number is " + max2);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num;

Console.Write("Please, enter the number :");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) Console.Write("The number is EVEN");
else Console.Write("The number is ODD");

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int num;
int current = 2;

Console.Write("Please, enter the number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    while (current < num)
    {
    Console.Write(current + " ");
    current = current + 2;
    }
    Console.Write(num);
}
else
{
    while (current < num)
    {
    Console.Write(current + " ");
    current = current + 2;
    }
}
