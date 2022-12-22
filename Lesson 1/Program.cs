// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее,
// а какое меньшее.
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
 
if(a > b)
    {
        Console.WriteLine("Первое число больше второго");
    }
else if (a < b)
    {
        Console.WriteLine("Первое число меньше второго");
    }
else
    {
        Console.WriteLine("Оба числа равны");
    }

// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
int max;
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
max = a;
if (b > a) max = b;
if (c > max) max = c;
Console.WriteLine("Максимальное число: " + max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int evenNnumber = a % 2;

if(evenNnumber == 0)
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число не является чётным");
}

// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(a > 1)
{
    while(evenNumber <= a)
    {   
        Console.Write(evenNumber + ",");
        evenNumber = evenNumber + 2;
    }
}