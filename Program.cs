using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equations
{
    using System;

        class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Solve Quadratic Equation");
                    Console.WriteLine("2. Calculate Area of a Circle");
                    Console.WriteLine("3. Apply Pythagorean Theorem");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();


                    switch (choice)
                    {
                        case "1":
                            SolveQuadraticEquation();
                            break;
                        case "2":
                            CalculateCircleArea();
                            break;
                        case "3":
                            ApplyPythagoreanTheorem();
                            break;
                        case "4":
                            Console.WriteLine("Exiting the program...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                            break;
                    }

                    Console.WriteLine();
                }
            }

            static void SolveQuadraticEquation()
            {
                Console.WriteLine("Solving Quadratic Equation (ax^2 + bx + c = 0)");
                Console.Write("Enter the value of a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the value of b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the value of c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                double discriminant = b * b - 4 * a * c;

                if (discriminant > 0)
                {
                    double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"Roots are real and different.Root 1 = {root1}\nRoot 2 = {root2}");
                }
                else if (discriminant == 0)
                {
                    double root = -b / (2 * a);
                    Console.WriteLine($"Roots are real and same.\nRoot 1 = Root 2 = {root}");
                }
                else
                {
                    double realPart = -b / (2 * a);
                    double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                    Console.WriteLine($"Roots are complex and different.\nRoot 1 = {realPart} + {imaginaryPart}i\nRoot 2 = {realPart} - {imaginaryPart}i");
                }
            }

            static void CalculateCircleArea()
            {
                Console.WriteLine("Calculating Area of a Circle");
                Console.Write("Enter the radius of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                double area = Math.PI * radius * radius;
                Console.WriteLine($"Area of the circle with radius {radius} = {area}");
            }

            static void ApplyPythagoreanTheorem()
            {
                Console.WriteLine("Applying Pythagorean Theorem (a^2 + b^2 = c^2)");
                Console.Write("Enter the value of a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the value of b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                double c = Math.Sqrt(a * a + b * b);
                Console.WriteLine($"The length of the hypotenuse (c) is {c}");
            }
        }
    

}
