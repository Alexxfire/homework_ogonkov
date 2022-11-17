// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
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
int Chetnyi(int[] array)                //определяем метод поиска четных чисел в массиве
{
    int quant = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0)          //условие четности
        {
            quant = quant + 1;
        }  
    }
    return quant;
}
int[] mainArray = NewArray(10,100,999);
PrintArray(mainArray);
Console.Write($"--> {Chetnyi(mainArray)} четных чисел в массиве");