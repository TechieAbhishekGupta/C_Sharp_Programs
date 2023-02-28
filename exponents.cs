// 14. Write a program to perform Multiplication and Division of Exponents of same base.

Console.Write("Enter the Base : ");
double num = double.Parse(Console.ReadLine());

Console.Write("Enter the First Exponent :");
double exp1 = double.Parse(Console.ReadLine());

Console.Write("Enter the Second Exponent :");
double exp2 = double.Parse(Console.ReadLine());

double mul = exp1 + exp2;

double div = exp1 - exp2;

Console.WriteLine("Result is : {0}^{1} : {2}", num, mul, Math.Pow(num, mul));
Console.WriteLine("Result is : {0}^{1} : {2}", num, div, Math.Pow(num, div));

Console.ReadLine();
