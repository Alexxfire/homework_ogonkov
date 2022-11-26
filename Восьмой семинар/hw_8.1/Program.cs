// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
void SwapElements(int[,] array, int i, int j1, int j2)
{
    int temp = array[i, j1];
    array[i, j1] = array[i, j2];
    array[i, j2] = temp;
}
int[,] SortElements(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            while (j > 0 && array[i, j - 1] < array[i, j])
            {
                SwapElements(array, i, j, j-1);
                j = j - 1;
            }
        }
    }
return array;
}
int[,] arrayMain = NewArray(4,4);
PrintArray(arrayMain);
Console.WriteLine();
SortElements(arrayMain);
PrintArray(arrayMain);