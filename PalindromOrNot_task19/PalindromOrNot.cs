
using System;

class Program
{
    static void Main()
    {
        int number = 0;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("input error!");
            Console.Write("Pleas re-enter: ");

        }

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




