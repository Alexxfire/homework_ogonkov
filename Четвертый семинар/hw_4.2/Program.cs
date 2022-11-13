// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Prompt(string message)                 //определяем метод ввода
{
    Console.Write(message);          
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}
bool ValidateNumber(int number)                  //определяем проверку
{
    if (number <= 0)
    {
        Console.WriteLine("Это не положительное число");
        return false;
    }
    return true;
}
int number=Prompt("Введите положительное число: ");
if (ValidateNumber(number)) 
{
    int sum = 0;
    do
    {
        sum = sum + number%10;                  //добавляем последнюю цифру к сумме
        number = number/10;                     //сокращаем число на 1 разряд
    }
    while (number >= 1);                         //условие - больше цифр не осталось
Console.WriteLine($"Сумма цифр = {sum}");
}