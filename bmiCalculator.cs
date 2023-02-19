// 9. Write a program that calculates the body mass index (BMI) given height and weight.
//BMI(Body Mass Index) = (Weight in KGs)/ (height * height in Meters)

Console.WriteLine("<---- BMI Calculator ---->");
Console.WriteLine("--------------------------");

Console.Write("Enter Weight (in KGs) : ");
float weight = float.Parse(Console.ReadLine());
Console.Write("Enter Height (in Meters) : ");
float height = float.Parse(Console.ReadLine());

BMI(weight, height); // BMI function calling 

Console.ReadKey();

void BMI(float weight, float height)
{
    float bmi = weight / (height * height);
    Console.WriteLine("Your BMI = " + Math.Round(bmi, 2) + " & ");

    if (bmi < 18.5) Console.WriteLine("You are Under Weight.");
    else if (bmi >= 18.5 && bmi < 24.9) Console.WriteLine("Your Weight is Normal. ");
    else if (bmi >= 24.9 && bmi < 29.9) Console.WriteLine("You are Over Weight.");
    else Console.WriteLine("You are Suffering from Obesity.");

}
