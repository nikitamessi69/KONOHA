/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int SumMandN(int M, int N)
{
    int result = M;
    if (M == N) return 0;
    else
    {
        M++;
        result = M + SumMandN(M, N); return result;
    }
}

void SumCall(int M, int N)
{
    Console.Write(SumMandN(M - 1, N));
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
SumCall(M, N);