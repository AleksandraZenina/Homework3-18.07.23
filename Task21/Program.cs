// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
void XYZRange(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double a = Math.Pow((x1 - x2), 2);
    double b = Math.Pow((y1 - y2), 2);
    double c = Math.Pow((z1 - z2), 2);    
    double result = Math.Sqrt(a + b + c);
    Console.WriteLine(result);
}
Console.Write("Введите число x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите число y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите число z1: ");
double z1 = double.Parse(Console.ReadLine());
Console.Write("Введите число x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите число y2: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите число z2: ");
double z2 = double.Parse(Console.ReadLine());
XYZRange(x1, y1, z1, x2, y2, z2);
