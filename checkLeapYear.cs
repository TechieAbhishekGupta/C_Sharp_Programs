// 8. Write a program that checks if a year is a leap year.

Console.Write("Enter YEAR : ");
int year = int.Parse(Console.ReadLine());

Console.WriteLine(checkLeap(year) ? $"Yes! {year} is Leap Year..." : $"NO! {year} is NOT Leap Year...");

Console.ReadKey();

bool checkLeap(int year)
{
    if (year % 400 == 0) return true;
    if (year % 100 == 0) return false;
    if (year % 4 == 0) return true;
    return false;
}
