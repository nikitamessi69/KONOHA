// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int n_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int n_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int n_3 = int.Parse(Console.ReadLine()!);

if (n_1 > n_2 && n_1 > n_3)
{
    Console.WriteLine("Большее число = " + n_1);
}
else if (n_2 > n_3)
{
    Console.WriteLine("Большее число = " + n_2);
}
else
{
    Console.WriteLine("Большее число = " + n_3);
}