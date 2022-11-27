// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Prompt(string message)                 //определяем метод ввода
{
    Console.Write(message);          
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}
bool ValidateNumber(int number1, int number2)                  //определяем проверку на натуральное число
{
    if (number1 < 0 || number2 < 0)
    {
        System.Console.WriteLine("Число/а отрицательное");
        return false;
    }
    return true;
}
int Main(int m, int n)             //определяем рекурсию
{
    if (m==0)
    {
        return n+1;
    }
    if (m > 0 && n == 0)
    {
       return(Main(m-1,1)); 
    }
    if (m > 0 & n > 0)
    {
        return(Main(m-1, Main(m,n-1)));
    }
    return 0;
}
int M = Prompt("Введите первое положительное число: ");
int N = Prompt("Введите второе положительное число: ");
if (ValidateNumber(M,N)) 
{
    Console.WriteLine(Main(M,N));
}