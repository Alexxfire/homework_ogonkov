//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int Prompt(string message)                 //определяем метод ввода
{
    Console.Write(message);          
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}
bool ValidateNumber(int number1, int number2)                  //определяем проверку
{
    if (number1 == 0 & number2 == 0)
    {
        Console.WriteLine("Не имеет смысла");
        return false;
    }
    if (number2 == 0)
    {
        Console.WriteLine($"{number1}, {number2} -> 1"); 
        return false; 
    }
    if (number1 < 0 || number2 < 0)
    {
        Console.WriteLine("Числа должны быть положительными");
        return false;
    }
    return true;
}
int Stepen(int num1, int num2)             //определяем функцию возведения в степень
{
    int result = num1;
    for (int i = 1; i<num2; i++)                 // цикл for
    {
        result = result*num1;
    }
    return result;
}
int A=Prompt("Введите число: ");
int B=Prompt("Введите степень: ");
if (ValidateNumber(A,B)) 
{
    int result = Stepen(A,B);
    Console.WriteLine($"{A}, {B} -> {result}");
}