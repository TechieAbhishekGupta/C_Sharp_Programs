// 1. Write a program that calculates the area of a circle given its radius.

Console.Write("Enter the Radius: ");
double radius = Convert.ToDouble(Console.ReadLine());

double area = (3.14) * radius * radius;

Console.WriteLine($"Area of Circle: {Math.Round(area,2)}");

Console.ReadKey();
