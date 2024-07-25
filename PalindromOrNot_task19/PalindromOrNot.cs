
using System;

class Program
{
    static void Main()
    {
        int number = 0;
        //while (!int.TryParse(Console.ReadLine(), out number))
        //{
        //    Console.WriteLine("input error!");
        //    Console.Write("Pleas re-enter: ");
        //}

        while(Convert.ToInt32())

        string strFromNum = GetRigthStr(number);

        IsPalindromOrNot(strFromNum);
    }

    static string GetRigthStr(int number)
    {
        if (number < 0)
        {
            return null;
        }
        else
        {
            return number.ToString();
        }
             
    }

    static void IsPalindromOrNot(string str)
    {
        int length = str.Length;
        bool isPolindrom = true;
    
        if (str == null)
        {
            Console.WriteLine("-1");
        }
        else
        { 

            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - 1 - i])
                { 
                    isPolindrom = false;
                    break;
                }
            }

            if (isPolindrom)
            {
                Console.WriteLine("Palindrom!");
            }
            else
            {
                Console.WriteLine("NOT palindrom!");
            }
        }
    }
}





// Напишите программу, которая принимает на вход (пятизначное( я усложнил задчу)) любое число и проверяет, является ли оно палиндромом?

//int number = 0;
//Console.WriteLine("enter five-digit:");

//while (!int.TryParse(Console.ReadLine(), out number))
//{
//    Console.WriteLine("input error!");
//    Console.Write("Pleas re-enter: ");
//}


//string resolt = GetRigthString(number);

//IsPalindromOrNot(resolt);


//string GetRigthString(int number)
//{
//    if (number < 0)
//    {
//        return null; // отрицательные числа не являются полиндромом
//    }
//    else return number.ToString();
//}

//void IsPalindromOrNot(string str)
//{
//    if (str == null)
//    {
//        Console.WriteLine("Error: The number is not a polindrom!");
//        return;
//    }

//    int length = str.Length;
//    bool isPolindrom = true;

//    for (int i = 0; i < length / 2; i++)
//    {
//        if (str[i] != str[length - i - 1])
//        {
//            isPolindrom = false; break;
//        }
        
//    }
//    if (isPolindrom)
//    {
//        Console.WriteLine("Palindrom!");
//    }
//    else
//    {
//        Console.WriteLine("NOT Palindrom!");
//    }

//}
