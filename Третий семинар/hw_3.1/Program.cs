// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом. Без использования строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int Prompt(string message)                      //определяем метод ввода данных
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)                  //определяем проверку
{
    if (number < 10000 || number > 99999)
    {
        System.Console.WriteLine("Это число не пятизначное");
        return false;
    }
    return true;
}
int number = Prompt("Введите положительное пятизначное число: ");    //ввод числа
if (ValidateNumber(number))                            //если прошло проверку
{
    if (number/10000 == number%10 & number/1000%10 == number/10%10)      //условие полиндрома
    {System.Console.WriteLine($"Число {number} - это полиндром!");
    }
    else 
    {
    System.Console.WriteLine($"Число {number} - не полиндром");
    }
}