// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance (double xa, double xb, double ya, double yb, double za, double zb)
{
    double lenth = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
    return lenth;
}

Console.Write("Введите значение координаты Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение координаты Х точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());



double lenth = Distance(xa, xb, ya, yb, za, zb);
Console.WriteLine($"Растояние между A и B = {lenth}");