Console.Write("Введите номер четверти: ");
int inputNum = 0;

while (!int.TryParse(Console.ReadLine(), out inputNum))
{
    Console.WriteLine("input error!");
    Console.WriteLine("Enter number 1 - 4:");
}

Console.WriteLine();

void GetNeedNumbers(int num)
{
    if (num == 1) Console.WriteLine("x > 0 & y > 0");
    else if (num == 2) Console.WriteLine("x < 0 & y > 0");
    else if (num == 3) Console.WriteLine("x < 0 & y < 0");
    else if (num == 4) Console.WriteLine("x > 0 & y < 0");
    else Console.WriteLine("input error, pleas restart prigram");
}

GetNeedNumbers(inputNum);