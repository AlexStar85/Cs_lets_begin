// Дано натуральное число N. Вывести на экран числа от 1 до N.

Console.WriteLine("Введите значение целого числа N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
    Console.Write(i);
    Console.Write(' ');
    i = i + 1;
}
 