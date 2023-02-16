// 3. Write a program that prints the larger of two numbers.

Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine($"{num1} is larger...");
else
    Console.WriteLine($"{num2} is larger...");

Console.ReadKey();
