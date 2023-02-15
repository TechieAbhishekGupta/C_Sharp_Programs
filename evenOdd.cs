// 2. Write a program that checks if a number is even or odd.

Console.Write("Enter Number: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine("Number is EVEN. ");
else
    Console.WriteLine("Number is ODD. ");

Console.ReadKey();
