// Задача №17: Напишите программу, которая принимает на вход координаты точек (X, Y) причем X не равно 0 и Y не равно 0. И выдает номер четверти плоскости, в которой находится эта точка.
int GetQuarter(int x, int y)
{
    if (x == 0 || y == 0) return -1;
    else if (x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else return 4;

}

Console.WriteLine(GetQuarter(1, 5));
Console.WriteLine(GetQuarter(1, -5));
Console.WriteLine(GetQuarter(-2, 5));
Console.WriteLine(GetQuarter(-2, -5));
Console.WriteLine(GetQuarter(0, -5));