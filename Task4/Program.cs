// Дано: 5 гирь с разными весам в случайном порядке
// Найти: вес самой тяжелой гири


Console.WriteLine("Введите значение целого числа a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение целого числа b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение целого числа c: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение целого числа d: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение целого числа e: ");
int e = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max)
{
    max = b;
    }

if (c > max)
{
    max = c;
    }

if (d > max)
{
    max = d;
    }
if (e > max)
{
    max = e;
    }

Console.WriteLine(max);
