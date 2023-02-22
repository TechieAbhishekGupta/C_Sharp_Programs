// 1. Write a program to calculate the area and circumference of a circle given its radius.

Console.Write("Enter the Radius: ");
double radius = Convert.ToDouble(Console.ReadLine());

double area = Math.PI * radius * radius;

double circumference = 2 * Math.PI * radius;

Console.WriteLine($"Area of Circle: {Math.Round(area,2)}");

Console.WriteLine($"Circumference of Circle: {Math.Round(circumference, 2)}");

Console.ReadKey();
