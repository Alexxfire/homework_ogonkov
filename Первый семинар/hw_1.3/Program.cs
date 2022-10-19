//на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число ");
string inputA = Console.ReadLine();
int a = Convert.ToInt32(inputA);
if (a >= 0)
{
    if (a % 2 > 0)
    {
    Console.WriteLine ($"число {a} нечетное");
    }
    else
    {
    Console.WriteLine ($"число {a} четное"); 
    }
}
else 
{
    if (-a % 2 > 0)
    {
    Console.WriteLine ($"число {a} нечетное");
    }
    else
    {
    Console.WriteLine ($"число {a} четное"); 
    }
}