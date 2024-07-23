//адача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.

using System;

class Program
{
    static void Main()
    {
        int number = 0;

        Console.Write("Enter integer N: ");

        while(!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("inpyt error, please restart enter :");
        }
        
        GetTableSquare(number);
    }
    
    static void GetTableSquare(int num)
    {
        for (int i = 1; i <= num -1; i++)
        {
            Console.Write($"{i * i}, ");
        }
        Console.WriteLine($"{num * num}");
    }
}



















