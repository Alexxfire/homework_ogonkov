// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] array)                    //определяем метод печати массива
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}
int Prompt(string message)                 //определяем метод ввода
{
    Console.Write(message);          
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}
bool ValidateNumber(int number1, int number2, int[,] array)                  //определяем проверку
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);
    if (number1 > height || number2 > width || number1 < 1 || number2 < 1)
    {
        Console.WriteLine("Такого элемента нет в массиве");
        return false;
    }
    return true;
}
int[,] fixArray = { {1,4,7,2}, {5,9,2,3}, {8,4,2,4} };
PrintArray(fixArray);
int i=Prompt("Введите строку: ");
int j=Prompt("Введите столбец: ");
if (ValidateNumber(i,j,fixArray)) 
{
    Console.WriteLine(fixArray[i-1,j-1]);
}