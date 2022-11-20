// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
float Prompt(string message)                 //определяем метод ввода
{
    Console.Write(message);          
    return float.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}
float[] PoiskPer(float b1, float k1, float b2, float k2)
{
    float[] array = new float[2];
    array[0] = (b2-b1)/(k1-k2);
    array[1] = array[0]*k1+b1;
    return array;
}
Console.Write("Введите параметры прямых линий определяемых уравнениями: \n y = k1 * x + b1, y = k2 * x + b2 \n"); 
float b1=Prompt("Введите b1: ");
float k1=Prompt("Введите k1: ");
float b2=Prompt("Введите b2: ");
float k2=Prompt("Введите k2: ");
Console.WriteLine($"Координата х пересечения линий = {PoiskPer(b1,k1,b2,k2)[0]}");
Console.WriteLine($"Координата y пересечения линий = {PoiskPer(b1,k1,b2,k2)[1]}");