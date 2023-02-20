// 10. Write a program that swaps the values of two variables.

Console.WriteLine("<---- Swapping Numbers Program ---->");
Console.Write("Enter first number : ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter second number : ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("\n------------------------------\n<---- Before Swapping ----> ");
Console.WriteLine("First Number : " + num1);
Console.WriteLine("Second Number : " + num2);

int temp = num1;
num1 = num2;
num2 = temp;

Console.WriteLine("\n------------------------------\n<---- After Swapping ----> ");
Console.WriteLine("First Number : " + num1);
Console.WriteLine("Second Number : " + num2);

Console.ReadKey();  
