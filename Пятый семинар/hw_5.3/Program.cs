// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76
double[] NewArray(int length, int min, int max)     //определяем метод создания массива 
{
	double[] tempArray = new double[length];
	for (int i = 0; i < length; i++)
	{
		tempArray[i] = new Random().Next(min, max+1)+(new Random().Next(min, max+1))*0.01;
	}
	return tempArray;
}
void PrintArray(double[] array)                    //определяем метод печати массива
{
    Console.Write($"[{array[0]}, ");
    for (int i = 1; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]}] ");
}
double PoiskMax(double[] array)                //определяем метод поиска максимума
{
    double maxx = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxx < array[i])
        maxx = array[i];
    }
    return maxx;
}
double PoiskMin(double[] array)                //определяем метод поиска минимума
{
    double minn = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minn > array[i])
        minn = array[i];
    }
    return minn;
}
double[] mainArray = NewArray(5,1,99);
PrintArray(mainArray);
Console.WriteLine($"max = {PoiskMax(mainArray)}");
Console.WriteLine($"min = {PoiskMin(mainArray)}");
Console.Write($"--> {PoiskMax(mainArray) - PoiskMin(mainArray)}: это разница");