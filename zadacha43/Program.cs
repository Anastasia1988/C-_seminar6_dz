// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и
//  k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Readint(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

var k1 = Readint("Введите значение k1 прямой direct1");
var b1 = Readint("Введите значение b1 прямой direct1");
var k2 = Readint("Введите значение k2 прямой direct2");
var b2 = Readint("Введите значение b2 прямой direct2");



double x = 0;
double y = 0;


x = Math.Round((-(b1 - b2) / (k1 - k2)), 3);
y = Math.Round((k1 * x + b1), 3);
System.Console.WriteLine($"Пересечение двух прямых будет в точке: {x};{y}");





