// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6
int Prompt(string message)                      //определяем метод ввода данных
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)                 //определяем проверку
{
    if (number < 100 && number > -100 )         //допускаем ввод отрицательного числа
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int number = Prompt("Введите трехзначное число: ");    //ввод числа
if (ValidateNumber(number))                            //если прошло проверку
{
    int temp = Math.Abs(number);
    int count = 0;
    while (temp/1000 > 0)                //вычисляем разряд до 3 цифры с конца числа
    {
    temp = temp / 10;
    count++;
    }
    int thirdDigit = Math.Abs (number / (Convert.ToInt32(Math.Pow(10, count))) % 10);
    System.Console.WriteLine($"Третья цифра числа {number} равна {thirdDigit}");
}