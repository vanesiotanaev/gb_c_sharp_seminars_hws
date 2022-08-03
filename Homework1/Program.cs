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


//Домашнее задание к семинару №3. 16.07.2022

//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool PalindromeMethod (int number)
{
    while (number <= 9999 || number >= 99999)
    {
        Console.Write("The number is not five-digit. Please, enter the five-digit number: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    int unitdigit = number % 10;
    int tensdigit = (number % 100) / 10;
    int hundredsdigit = (number % 1000) / 100;
    int thousandsdigit = (number % 10000) / 1000;
    int tensofthousandsdigit = number / 10000;

    if (unitdigit == tensofthousandsdigit && tensdigit == thousandsdigit) 
    {
       Console.Write("The number " + number + " is a Palindrome!");
       return true; 
    }
    else 
    {
        Console.Write("The number " + number + " is not a Palindrome!");
        return false;
    }
    
}

Console.Write("Please, enter the number: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
bool answer = PalindromeMethod(usernumber);

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance3DMethod (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double hypotenuse2D = Math.Sqrt((yB - yA) * (yB - yA) + (xB - xA) * (xB - xA));
    double hypotenuse3D = Math.Sqrt((hypotenuse2D * hypotenuse2D) + (zB - zA) * (zB - zA));

    return hypotenuse3D;
}

Console.Write("Please, enter the x-coordinate of A: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter the y-coordinate of A: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter the z-coordinate of A: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter the x-coordinate of B: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter the y-coordinate of B: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter the z-coordinate of B: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double answer = Distance3DMethod(x1, y1, z1, x2, y2, z2);
Console.Write ("The distance between A and B is " + answer);



//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ThirdDegreeMethod (int number)
{
    if (number >= 1)
    {
        Console.Write("Table of numbers from 1 to N in the 3rd degree: ");
        int current = 1;
        while (current <= number)
        {
            int thirddegree = current * current * current;
            current++;
            Console.Write(thirddegree + " ");
        }
        return number;
    }
    else
    {
        Console.Write("The number must be positive and no less than 1!");
        return 0;  
    }
    
}

Console.Write("Please, enter the N-number: ");
int usernumber = Convert.ToInt32(Console.ReadLine());
int N = ThirdDegreeMethod(usernumber);

//Домашнее задание к семинару №4. 03.08.2022

//1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ValueToThePowerMethod(int a, int b)
{
    if (b != 0)   
    {
        int value = a;
        for (int i = 1; i < b; i++)
        {
            a = a * value;
        }
        Console.WriteLine($"{value} to the power of {b} is {a}!");
        return a;
    }
    else
    {
        Console.WriteLine($"The power must be represented by a natural number!");
        return a;
    }
}

Console.Write("Please, enter the number: ");
int usernumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter the power: ");
int userpow = Convert.ToInt32(Console.ReadLine());

int result = ValueToThePowerMethod(usernumb, userpow);

// 2. Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ValueNumbersSumMethod (int number)
{
    int temp = number;
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.Write($"The sum of numbers in the value {temp} is {sum}!");
    return sum;
}

Console.Write("Please, enter the number: ");
int usernumb = Convert.ToInt32(Console.ReadLine());
int result = ValueNumbersSumMethod(usernumb);

*/

// 3. Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] UserArrayMethod()
{
    int size = 8;
    int[] array = new int[size];

    for (int count = 0; count < size; count++)
    {
        Console.Write($"Введите {count+1}й элемент массива: ");
        array[count] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArrayMethod(int[] array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] genarray = UserArrayMethod();
ShowArrayMethod(genarray);