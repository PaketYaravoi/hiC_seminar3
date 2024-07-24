// //Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B(2, 1, - 7) -> 18.84
// A(7, -5, 0); B(1, -1, 9) -> 11.53

using System;

class Program
{
    static void Main()
    {
        double answer = 0;

        int ax, ay, az, bx, by, bz;

        InputPoints(out ax, out ay, out az, out bx, out by, out bz);
        answer = GetDistanceBetweenPoint(ax, ay, az, bx, by, bz);
        Console.WriteLine($"distance bitween pint in 3D = {answer:f}");

    }
    static void InputPoints(
        out int ax, out int ay, out int az,
        out int bx, out int by, out int bz)
        
    {
        Console.WriteLine("Enter coordinates of the first point (ax): ");
        while (!int.TryParse(Console.ReadLine(), out ax))
        {
            Console.WriteLine("Input error!");
            Console.Write("Enter coordinates of the first point(ax) :");
        }
        Console.WriteLine("Enter coordinates of the first point (ay): ");
        while (!int.TryParse(Console.ReadLine(), out ay))
        {
            Console.WriteLine("Input error!");
            Console.Write("Enter coordinates of the first point(ay): ");
        }
        Console.WriteLine("Enter coordinates of the first point (az): ");
        while (!int.TryParse(Console.ReadLine(), out az))
        {
            Console.WriteLine("Input error!");
            Console.Write("Enter coordinates of the first point(az): ");
        }
        Console.WriteLine("Enter coordinates of the first point (bx): ");
        while (!int.TryParse(Console.ReadLine(), out bx))
        {
            Console.WriteLine("Input error!");
            Console.Write("Enter coordinates of the first point(bx): ");
        }
        Console.WriteLine("Enter coordinates of the first point (by): ");
        while (!int.TryParse(Console.ReadLine(), out by))
        {
            Console.WriteLine("Input error!");
            Console.Write("Enter coordinates of the first point(by): ");
        }
        Console.WriteLine("Enter coordinates of the first point (bz): ");
        while (!int.TryParse(Console.ReadLine(), out bz))
        {
            Console.WriteLine("Input error!");
            Console.Write("Enter coordinates of the first point(bz): ");
        }
        

    }
    static double GetDistanceBetweenPoint(
        int ax, int ay, int az,
        int bx, int by, int bz)
        
    {
        int firstSq = 0;
        int secondSq = 0;
        int therdSq = 0;
        int distance = 0;

        double answer = 0;
        
        {
            firstSq = (ax - bx) * (ax - bx);
            secondSq = (ay - by) * (ay - by);
            therdSq = (az - bz) * (az - bz);

            distance = firstSq + secondSq + therdSq;

            return answer = Math.Sqrt(distance);

        }
    }
    

}
