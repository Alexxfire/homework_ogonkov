// Задача 4 (*) При помощи рекурсии вывести последовательность чисел, 
//с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5
int Prompt(string message)                 //определяем метод ввода
{
    Console.Write(message);          
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}
bool ValidateNumber(int number)                  //определяем проверку 
{
    if (number < 1)
    {
        System.Console.WriteLine("Это число не положительное");
        return false;
    }
    return true;
}
void Recur(int number)                      //рекурсия
{
    for (int i = 1; i <= number; i++)
   {
        Console.Write($"{number} ");
   }
    Recur(number-1);
 }
int number = Prompt("Введите положительное число: ");    //ввод числа
if (ValidateNumber(number))                            //если прошло проверку
{
    Recur(number); 
}