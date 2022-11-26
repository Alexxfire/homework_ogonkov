// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] NewArray(int m, int n)     //определяем метод создания многомерного массива 
{
    int[,] tempArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            tempArray[i, j] = new Random().Next(0, 9);
        }
    }
    return tempArray;
}
void PrintArray(int[,] array)                    //определяем метод печати массива
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
int SumLine(int[,] array, int i)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    return sum;
}
int Main(int[,] array)
{
    int sum_0 = SumLine(array, 0);
    int line = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumline = SumLine(array, i);
        if (sumline < sum_0)
        {
            sum_0 = sumline;
            line = i;
        }
    }
    return line;
}
int[,] arrayMain = NewArray(4, 4);
PrintArray(arrayMain);
//Console.Write(SumLine(arrayMain, 2));
Console.Write($"Строка с наименьшей суммой -> {Main(arrayMain)+1}");