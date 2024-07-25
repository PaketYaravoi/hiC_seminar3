// Напишите программу которая принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N.

// 3 --> 1, 8, 27;
// 5 --> 1, 8, 27, 64, 125;

using System;

class Program
{
    static void Main()
    {
        int inputNum = 0;

        Console.Write("Please, enter integer: ");
        while (Conver.ToInt32(Console.ReadLine(), out inputNum))
        {
            Console.WriteLine("Input error!");
            Console.Write("Please, restart enter integer: ");
        }

        PrinTableCube(inputNum);

    }

    static void PrintTableCube



}

