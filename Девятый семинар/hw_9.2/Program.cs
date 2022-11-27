// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
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
    if (number1 > number2)
    {
        System.Console.WriteLine("Второе число должно быть больше первого");
        return false;
    }
    return true;
}
int Main(int a, int b)             //определяем рекурсию
{
    if (b < a)
    {
        return 0;
    }
    return(a + (Main(a+1,b)));
}
int M = Prompt("Введите первое натуральное число: ");
int N = Prompt("Введите второе натуральное число: ");
if (ValidateNumber(M,N)) 
{
    Console.WriteLine(Main(M,N));
}