// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] NewArray(int length, int min, int max)     //определяем метод создания массива 
{
	int[] tempArray = new int[length];
	for (int i = 0; i < length; i++)
	{
		tempArray[i] = new Random().Next(min, max+1);
	}
	return tempArray;
}
void PrintArray(int[] array)                    //определяем метод печати массива
{
    Console.Write($"[{array[0]}, ");
    for (int i = 1; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}
int SumNechetnyi(int[] array)                //определяем метод суммирования нечетных позиций
{
    int sum = 0;
    for (int i = 0; i < array.Length;)
    {
        sum = sum + array[i];
        i = i + 2;
    }
    return sum;
}
int[] mainArray = NewArray(5,-99,99);
PrintArray(mainArray);
Console.Write($"--> {SumNechetnyi(mainArray)}: сумма нечетных позиций");