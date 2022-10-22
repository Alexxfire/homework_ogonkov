// Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
int Prompt(string message)                 //определяем метод ввода
{
    System.Console.Write(message);          
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}
int x1=Prompt("Введите x1:");
int y1=Prompt("Введите y1:");
int z1=Prompt("Введите z1:");
int x2=Prompt("Введите x2:");
int y2=Prompt("Введите y2:");
int z2=Prompt("Введите z2:");
int x=x1-x2;
int y=y1-y2;
int z=z1-z2;
double Lenght= Math.Sqrt(x*x+y*y+z*z);    //квадратный корень из сумм квадратов 
Console.WriteLine($"{Lenght:f2}");