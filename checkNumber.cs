// 6. Write a program that checks if a number is positive, negative, or zero.

Console.Write("Enter the Number : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
    Console.WriteLine("Number is POSITIVE...");
else if (num < 0)
    Console.WriteLine("Number is NEGATIVE...");
else
    Console.WriteLine("Number is ZERO...");

Console.ReadKey();
