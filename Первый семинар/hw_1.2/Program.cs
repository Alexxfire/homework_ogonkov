//принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число ");
string inputA = Console.ReadLine();
int a = Convert.ToInt32(inputA);
Console.Write("Введите второе число ");
string inputB = Console.ReadLine();
int b = Convert.ToInt32(inputB);
Console.Write("Введите третье число ");
string inputC = Console.ReadLine();
int c = Convert.ToInt32(inputC);
int max = a;
if (b>max)
{
    max = b;
}
else
{}
if (c > max)
{
max = c;
}
else
{} 
Console.WriteLine ($"max={max}");
