// Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void PrintArray(int[] array)                    //определяем метод печати массива
{
    Console.Write($"[{array[0]}, ");
    for (int i = 1; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]}] ");
}
int[] NewArray()                                //определяем метод заполнения массива 
{
    int[] tempArray = new int[5];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = int.Parse(Console.ReadLine());
    }
    return tempArray;
}
int Poisk (int[] array)                  //определяем метод поиска положительных чисел
{
    int pol = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        pol = pol+1;
    }
    return pol;
}
Console.WriteLine("Введите 5 чисел. Ввод каждого числа подтвердите клавишей Enter");
int[] array1 = NewArray();
PrintArray(array1);
Console.WriteLine($"-> {Poisk(array1)}");