// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("put your b1 number: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("put your k1 number: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("put your b2 number: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("put your k2 number: ");
double k2 = Convert.ToDouble(Console.ReadLine());


double X(double b1, double k1, double b2, double k2)
{
    double x = -(b1 - b2) / (k1 - k2);
    return x;
}

double Y(double b1, double k1)
{
    double x = X(b1, k1, b2, k2);
    double y = k1 * x + b1;
    return x;
}

double x = X(b1, k1, b2, k2);
double y = Y(b1, k1);
x = Math.Round(x, 2);
y = Math.Round(y, 2);
Console.WriteLine($"point of two lines crossing: ({x},{y})");