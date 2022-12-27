/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.WriteLine("Введите координаты: ");
int Ax, Ay, Az;
int Bx, By, Bz;

Console.Write("Ax: ");
Ax = Convert.ToInt32(Console.ReadLine());

Console.Write("Ay: ");
Ay = Convert.ToInt32(Console.ReadLine());

Console.Write("Az: ");
Az = Convert.ToInt32(Console.ReadLine());

Console.Write("Bx: ");
Bx = Convert.ToInt32(Console.ReadLine());

Console.Write("By: ");
By = Convert.ToInt32(Console.ReadLine());

Console.Write("Bz: ");
Bz = Convert.ToInt32(Console.ReadLine());


{
    resultDoub = Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2);
}
Console.WriteLine(resultDoub);