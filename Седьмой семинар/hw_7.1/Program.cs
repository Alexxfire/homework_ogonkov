// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] NewArray(int m, int n)     //определяем метод создания многомерного массива 
{
	double[,] tempArray = new double[m,n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
        {   
            tempArray[i,j] = new Random().Next(-9, 9)+(new Random().Next(1, 99))*0.01;
        }
    }
	return tempArray;
}
void PrintArray(double[,] array)                    //определяем метод печати массива
{
    int height = array.GetLength(0);
    int width = array.GetLength(1);
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{array[i,j]:f2} \t");
        }
        Console.WriteLine();
    }
}
PrintArray(NewArray(3,4));