// Даны два целых числа. Вывести на экран большее из них


Console.WriteLine("Введите значение целого числа a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение целого числа b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine(a);
else
    Console.WriteLine(b);
