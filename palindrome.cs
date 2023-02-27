// 13. Write a program to Reverse a number and check if it a Palindrome.

int num, temp, remainder, reverse = 0;

Console.Write("Enter the number: ");
num = int.Parse(Console.ReadLine());

temp = num;

while (num > 0)
{
    remainder = num % 10;
    reverse = reverse * 10 + remainder;
    num /= 10;
}

Console.WriteLine($"\nProvided number is = {temp}");
Console.WriteLine($"Its reverse is  = {reverse}");

if (temp == reverse)
    Console.WriteLine("\n\nYES! Number is a Palindrome. \n");
else
    Console.WriteLine("\n\nNumber is NOT Palindrome. \n");

Console.ReadLine();
