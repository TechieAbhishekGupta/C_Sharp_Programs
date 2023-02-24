// 11. Write a program to reverse a given number.

Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());

reverseNumber(n);

Console.ReadKey();

void reverseNumber(int n)
{
    int rem, reverse = 0;
    while (n != 0)
    {
        rem = n % 10;
        reverse = reverse * 10 + rem;
        n /= 10;
    }
    Console.Write($"Reversed Number: {reverse}");
}
