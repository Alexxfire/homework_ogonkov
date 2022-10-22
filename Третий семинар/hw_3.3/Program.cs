// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int Prompt(string message)                  //определяем метод ввода
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
int number = Prompt("Введите положительное число: ");    //ввод числа
if (ValidateNumber(number))                            //если прошло проверку
{
    System.Console.Write($"{number} -> ");             //вывод числа с  ->
    for (int i = 1; i<number; i++)                      // цикл for
    {
        System.Console.Write($"{Math.Pow(i,3)}, ");
    }
    System.Console.Write(Math.Pow(number,3));           //вывод последнего числа без запятой
}