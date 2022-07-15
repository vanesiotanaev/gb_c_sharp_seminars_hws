//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
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


// Домашнее задание №2. 15.07.2022

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondNumMethod (int number)
{
    int num2 = (number / 10) % 10;
    return num2;
}

Console.Write("Please, enter the three-digit number: ");
int usernum = Convert.ToInt32(Console.ReadLine());

while (usernum < 100 || usernum > 999)
{
    Console.Write("The number is not three-digit! Please, enter the three-digit number: ");
    usernum = Convert.ToInt32(Console.ReadLine());
}
    int answer = SecondNumMethod(usernum);
    Console.Write("The second digit of this number is " + answer);

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigitMethod (int number)
{
    if (number < 100)
    {
        Console.WriteLine("There is no 3rd digit in number " + number);
        return 0;
    }
    else
    {
        Console.WriteLine("The number has 3 (or more) digits in it");
        while (number > 999)
        {
            number = number / 10;
        }
        number = number % 10;
        Console.Write ("The third digit is " + number);
        return number;
    }
}

Console.Write("Please, enter the number: ");
int usernum = Convert.ToInt32(Console.ReadLine());
int answer = ThirdDigitMethod (usernum);

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool WeekDayMethod (int daynumb)
{
    while (daynumb > 7 || daynumb < 1)
    {
        Console.Write("There is no such day of the week. Please, enter the correct number of the day: ");
        daynumb = Convert.ToInt32(Console.ReadLine());
    }
    if (daynumb <= 5)
    {
    if (daynumb == 1) Console.Write("Monday is not a weekend!"); 
    if (daynumb == 2) Console.Write("Tuesday is not a weekend!");
    if (daynumb == 3) Console.Write("Wednesday is not a weekend!");
    if (daynumb == 4) Console.Write("Thursday is not a weekend!");
    if (daynumb == 5) Console.Write("Friday is almost the weekend, but it is not Saturday or Sunday!");

    return false;
    }
    
    else
    {
    if (daynumb == 6) Console.Write("Saturday is the weekend! Cool!");
    if (daynumb == 7) Console.Write("Sunday is the weekend! Cool!");
    
    return true;
    }
}

Console.Write("Please, enter the number: ");
int userdaynum = Convert.ToInt32(Console.ReadLine());
bool answer = WeekDayMethod (userdaynum);