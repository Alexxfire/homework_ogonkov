// на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число больше '2' ");   //нет четных чисел меньше 2
string inputA = Console.ReadLine();
int a = Convert.ToInt32(inputA);
int evenNumber = 2;                    //определим мин. четное число, которое будем выводить на экран

if (a > 2)                             //проверка
{
    while (evenNumber < (a-2))          //без последнего четного числа
     {   
     Console.Write($"{evenNumber}, ");
     evenNumber=evenNumber+2;           //находим следующее четное число
     }
    Console.Write(evenNumber);          //выводим последнее четн. число без запятой
}
else 
{
    Console.WriteLine ("неверно введено число");
}