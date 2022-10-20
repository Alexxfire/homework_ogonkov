// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int Prompt(string message)                      //определяем метод ввода данных
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)                  //определяем метод проверки
{
    if (number < 1 || number > 7)
    {
        System.Console.WriteLine("Неверно, попробуйте еще раз");
        return false;
    }
    return true;
}
int number = Prompt("Введите число дня недели от 1 до 7: ");     //ввод числа
if (ValidateNumber(number))                                      //если прошло проверку
{
    string[] week = new string[7] {"нет","нет","нет","нет","нет","да","да"};
    Console.WriteLine($"{number} выходной? - {week[number-1]}");
}