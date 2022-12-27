/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
string randomNumb = Console.ReadLine();
int len = randomNumb.Length;

if (len == 5)
{
    if (randomNumb[0] == randomNumb[4] && randomNumb[1] == randomNumb[3])
    {
        Console.WriteLine($"{randomNumb} - палиндром!");
    }
    else
    {
       Console.WriteLine($"{randomNumb} - не палиндром!"); 
    }
}