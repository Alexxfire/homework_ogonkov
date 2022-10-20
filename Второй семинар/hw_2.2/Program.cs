// Напишите программу, которая выводит случайное трёхзначное число и удаляет 
//вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(99, 1000);     //случайное 3-х значное число 
int numberTen = number / 100 * 10;
int numberOne = number % 10; 
Console.Write($"{number} -> {numberTen+numberOne}");     