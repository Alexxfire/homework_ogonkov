// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int[,] ArrayMult (int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0),array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int sum=0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum=sum+(array1[i,k]*array2[k,j]);
            }
            array3[i,j] = sum;       
        }
    }
    return array3;
}
int[,] array1 = NewArray(2, 2);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = NewArray(2, 2);
PrintArray(array2);
Console.WriteLine();
PrintArray(ArrayMult(array1,array2));