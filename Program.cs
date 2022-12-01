/*
// Задача 1.
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3 

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = b;

if(a > b)
{
    max = a;
}
    Console.WriteLine($"Max number = {max}");
*/

// Задача 2. 
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = c;

if(b > a)
    {
        max = b;
    }

if(b > c)
    {
        max = b;
    }
Console.WriteLine($"Max number = {max}");
*/
/*
// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a % 2;

if (b == 0)
    {
        Console.WriteLine("Number " + a + " is even");
    }
else
    {
        Console.WriteLine("Number " + a + " is not even");
    }
*/
// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

int current = 1;
int b = current % 2; 

while (current <= N)
    {
        if(b == 0)
            {
                Console.Write(current + " ");
            }
        current = current + 1;
        b = current % 2;

    }

