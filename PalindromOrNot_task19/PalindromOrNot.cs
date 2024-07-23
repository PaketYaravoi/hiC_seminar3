
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом?

int number = 0;
Console.WriteLine("enter five-digit:");

while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("input error!");
    Console.Write("Pleas re-enter: ");
}


string resolt = GetRigthString(number);
GetAnswer(resolt);


string GetRigthString(int number)
{
    string strFromNum = string.Empty;
   

    if (number > 99999 || number < 10000)
    {
        return null;
    }
    else
    {
        strFromNum = number.ToString();
    }
    return strFromNum;

}

void GetAnswer(string str)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine("Palindrom!");
    }
    else
    {
        Console.WriteLine("NOT Palindrom!");
    }
}