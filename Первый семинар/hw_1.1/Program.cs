//на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число ");
string inputA = Console.ReadLine();
int a = Convert.ToInt32(inputA);
Console.Write("Введите второе число ");
string inputB = Console.ReadLine();
int b = Convert.ToInt32(inputB);
if (a==b)
{
    Console.WriteLine ($"max=both {a}");
}
else
{
    if (a > b)
        {
        Console.WriteLine ($"max={a}");
        }
    else 
        {
        Console.WriteLine ($"max={b}");
        }
}