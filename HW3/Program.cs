using System;
using System.Collections.Generic;
using System.Globalization;


List<string> nums = [];
List<string> errs = [];
string num;
Console.Write("введите число (q - выход): ");
num = Console.ReadLine();

for (int i = 0; num != "q";)
{
    if (int.TryParse(num, out i))
    {
        string s = Convert.ToString(i);
        nums.Add(s);
    }
    else
    {
        Console.WriteLine("ввели не число! ");
        errs.Add(num);
        num = null;

        Console.WriteLine("1 - продолжить");
        Console.WriteLine("2 - очистить");
        Console.WriteLine("3 - выйти");

        string temp = Console.ReadLine();

        switch (temp)
        {
            case ("1"):
                Console.WriteLine("продолжайте ввод");
                break;

            case ("2"):

                nums.Clear();
                errs.Clear();
                Console.WriteLine("очистили результаты");
                break;

            case ("3"):
                Console.WriteLine("выход");
                goto end;
        }
    }
    Console.Write("введите число (q - выход): ");
    num = Console.ReadLine();
}

Console.WriteLine("ввели q");
end:
Console.WriteLine("вывод введенных чисел:");
foreach (string digit in nums)
{
    Console.WriteLine(digit);
}
Console.WriteLine("вывод ошибок ввода:");
foreach (string symb in errs)
{
    Console.WriteLine(symb);
}