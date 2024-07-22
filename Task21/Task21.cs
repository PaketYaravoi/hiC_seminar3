//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B(2, 1)-> 5,09
//A(7, -5); B(1, -1)-> 7,21

int ax, ay, bx, by;
double answer = 0;

void InputAllPoint(out int ax , out int ay , out int bx , out int by )
{
    Console.WriteLine("Enter coordinates of the first point (ax) : ");
    while (!int.TryParse(Console.ReadLine(), out ax))
    {
        Console.WriteLine("Input error!");
        Console.Write("Enter coordinates of the first point(ax) :");
    }

    Console.WriteLine("Enter coordinates of the first point (ay) : ");
    while (!int.TryParse(Console.ReadLine(), out ay))
    {
        Console.WriteLine("Input error!");
        Console.Write("Enter coordinates of the first point(ay) :");
    }

    Console.WriteLine("Enter coordinates of the second point (bx) : ");
    while (!int.TryParse(Console.ReadLine(), out bx))
    {
        Console.WriteLine("Input error!");
        Console.Write("Enter coordinates of the first point(bx) :");
    }

    Console.WriteLine("Enter coordinates of the second point (by) : ");
    while (!int.TryParse(Console.ReadLine(), out by))
    {
        Console.WriteLine("Input error!");
        Console.Write("Enter coordinates of the first point(by) :");
    }

}

double GetDistance(int ax, int ay, int bx, int by)
{
    int firstPointSq = 0;
    int secondPointSq = 0;
    int distanceSq = 0;
    double unswer = 0;

    firstPointSq = (ax - bx) * (ax - bx);
    secondPointSq = (ay - by) * (ay - by);
    distanceSq = firstPointSq + secondPointSq;
    
    return unswer = Math.Sqrt(distanceSq);
}

InputAllPoint(out ax, out ay, out bx, out by);
answer = GetDistance(ax,ay, bx, by);
Console.WriteLine($"distance between points = {answer:f2}");
