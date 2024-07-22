
// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.


int number = 0;
Console.Write("Input five-digit:");


while(!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("input error!");
    Console.Write("Pleas re-enter: ");
}


string GetStringWithNumber(int number)
{
    string str = number.ToString();
    return str;
}


string sringNow = GetStringWithNumber(number);



//void PalindromOrNot(int number)
//{
//    int firstNumber = 0;
//    int secondNumber = 0;

//    if (number > 99999 || number < 10000)
//    {
//        Console.WriteLine("enter error!");
//        Console.Write("Pleas restart program: ");
//    }
//    else
//    {
//        firstNumber = number / 1000;
//        secondNumber = number % 100;
        
//        if (secondNumber == firstNumber)
//        {
//            Console.WriteLine($"{number} - Polindrom!");
//        }
//        else
//        {
//            Console.WriteLine($"{number} - not polindrom!");
//        }
//    }

//}

//PalindromOrNot(number);



