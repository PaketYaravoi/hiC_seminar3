string input = "1 5 6 7 12 36 55";

int[] inputNew = input.Split().Select(int.Parse).ToArray(); //можно передать как массив строки введеный по умолчанию(фиксированная строка)

int[] resolt  = Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray();     // так и массив строк введеный вручную (ReadLine())

                                                    // по умолчаюнию Сплит увидит массив в строке или при вводе нужно указать параметр разделителя
                                                    // если ошибится при вводе , он просто склеит их , так как не увидит разделителных знаков
                                                    //                    Parse - им из массива строк в  цело-ый  массив данных (.ToArray)
Console.WriteLine();

foreach (int i in resolt)               // можно вложить resolt можно вложить inputNew, только не строку input) так как это строка а не мосивы данных как в случае с inputNew
{
    Console.Write(i + "; ");
}
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < resolt.Length; i++)
{
    Console.Write(resolt[i] + "; ");
}
