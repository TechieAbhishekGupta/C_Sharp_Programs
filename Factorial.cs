// 7. Write a program that calculates the factorial of a number.

Console.Write("Enter Number : ");
int num = int.Parse(Console.ReadLine());
int fact = 1;
for (int i = 1; i <= num; i++)
    fact= fact * i;

Console.WriteLine("FACTORIAL of {0} = {1}.",num, fact);

Console.ReadKey();
