// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] NewArray(int m, int n)     //определяем метод создания многомерного массива 
{
	int[,] tempArray = new int[m,n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
        {   
            tempArray[i,j] = new Random().Next(0, 9);
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
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}
void Average(int[,] array)
{int height = array.GetLength(0);
    int width = array.GetLength(1);
    double sum = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < width; j++)
    {
        for (int i = 0; i < height; i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{sum / height:f2}  ");
        sum = 0;
    }
}
int[,] arrayMain = NewArray(3,4);
PrintArray(arrayMain);
Average(arrayMain);