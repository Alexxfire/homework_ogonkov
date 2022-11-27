// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"
int Prompt(string message)                 //определяем метод ввода
{
    Console.Write(message);          
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}
bool ValidateNumber(int number1, int number2)                  //определяем проверку на натуральное число
{
    if (number1 < 1 || number2 < 1)
    {
        System.Console.WriteLine("Число/а не натуральное");
        return false;
    }
    if (number1 >= number2)
    {
        System.Console.WriteLine("Второе число должно быть больше первого");
        return false;
    }
    return true;
}
void Main(int a, int b)             //определяем рекурсию
{
    if (b < a)
    {
        return;
    }
    if (a%2 == 0)
    {
        Console.WriteLine(a);
    }
    Main(a+1,b);
}
int M = Prompt("Введите первое натуральное число: ");
int N = Prompt("Введите второе натуральное число больше первого: ");
if (ValidateNumber(M,N)) 
{
    Main(M,N);
}