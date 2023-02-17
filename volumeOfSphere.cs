// 5. Write a program that calculates the volume of a sphere given its radius.
// Volume of Sphere = 4/3 * pi * r * r * r

Console.Write("Enter the RADIUS: ");
float radius = float.Parse(Console.ReadLine());

float volume = (float)((4.0/3) * 3.14 * radius * radius * radius);
Console.WriteLine("Volume of Sphere : " + Math.Round(volume, 2));

Console.ReadKey();
