// 12. Write a program to generate Fibonacci Series.

int i, count, f1 = 0, f2 = 1, f3 = 0;

Console.Write("Enter the Limit : ");
count = int.Parse(Console.ReadLine());

Console.Write($"{f1}, ");
Console.Write($"{f2}, ");

for (i = 0; i <= count; i++)
{
    f3 = f1 + f2;
    Console.Write($"{f3}, ");
    f1 = f2;
    f2 = f3;
}
Console.ReadLine();
