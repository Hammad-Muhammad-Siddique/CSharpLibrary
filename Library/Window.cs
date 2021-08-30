using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLibrary
{
    class Random
    {
        public static void AddText(string text)
        {
            Console.WriteLine(text);

       
        }

        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }

        public static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }

        public static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }

        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Compare(int num1, int num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is greater");
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2 + " is greater");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }
        }

        public static void Grade()
        {
            string tresholdType;
            int marks;
            int AStarUpperLimit;
            int AStarLowerLimit = 0;
            int AUpperLimit;
            int ALowerLimit = 0;
            int BUpperLimit;
            int BLowerLimit = 0;
            int CUpperLimit;
            int CLowerLimit = 0;
            int DUpperLimit;
            int DLowerLimit = 0;
            int EUpperLimit;
            int ELowerLimit = 0;
            int FUpperLimit;
            int FLowerLimit = 0;
            int UUpperLimit;
            int ULowerLimit = 0;
            int customMarks;
 

            Console.WriteLine("Do you want to create grade treshold or use default threshold?");
            Console.WriteLine();
            Console.WriteLine("Enter default for default threshold and custom to create one");
            tresholdType =  Console.ReadLine();

            if (tresholdType == "custom")
            {
        
                Console.WriteLine("Enter the upper limit for A*. If your grade threshold doesn't have an A*, enter -1");
                AStarUpperLimit = Convert.ToInt32(Console.ReadLine());

                if (AStarUpperLimit != -1)
                {
                    Console.WriteLine("Enter A* lower limit");
                    AStarLowerLimit = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter the upper limit for A. If your grade threshold doesn't have an A, enter -1");
                AUpperLimit = Convert.ToInt32(Console.ReadLine());

                if (AUpperLimit != -1)
                {
                    Console.WriteLine("Enter A lower limit");
                    ALowerLimit = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter the upper limit for B. If your grade threshold doesn't have an B, enter -1");
                BUpperLimit = Convert.ToInt32(Console.ReadLine());

                if (BUpperLimit != -1)
                {
                    Console.WriteLine("Enter B lower limit");
                    BLowerLimit = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter the upper limit for C. If your grade threshold doesn't have an C, enter -1");
                CUpperLimit = Convert.ToInt32(Console.ReadLine());

                if (CUpperLimit != -1)
                {
                    Console.WriteLine("Enter C lower limit");
                    CLowerLimit = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter the upper limit for D. If your grade threshold doesn't have an D, enter -1");
                DUpperLimit = Convert.ToInt32(Console.ReadLine());

                if (DUpperLimit != -1)
                {
                    Console.WriteLine("Enter D lower limit");
                    DLowerLimit = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter the upper limit for E. If your grade threshold doesn't have an E, enter -1");
                EUpperLimit = Convert.ToInt32(Console.ReadLine());

                if (EUpperLimit != -1)
                {
                    Console.WriteLine("Enter E lower limit");
                    ELowerLimit = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter the upper limit for F. If your grade threshold doesn't have an F, enter -1");
                FUpperLimit = Convert.ToInt32(Console.ReadLine());

                if (FUpperLimit != -1)
                {
                    Console.WriteLine("Enter F lower limit");
                    FLowerLimit = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Enter the upper limit for U. If your grade threshold doesn't have an U, enter -1");
                UUpperLimit = Convert.ToInt32(Console.ReadLine());

                if (UUpperLimit != -1)
                {
                    Console.WriteLine("Enter U lower limit");
                    ULowerLimit = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();

                Console.Write("Now enter marks: ");
                customMarks = Convert.ToInt32(Console.ReadLine());

                if (AStarUpperLimit != -1)
                {
                    if (customMarks <= AStarUpperLimit && customMarks >= AStarLowerLimit)
                    {
                        Console.WriteLine("The grade is A*");
                    }
                }

                if (AUpperLimit != -1)
                {
                    if (customMarks <= AUpperLimit && customMarks >= ALowerLimit)
                    {
                        Console.WriteLine("The grade is A");
                    }
                }

                if (BUpperLimit != -1)
                {
                    if (customMarks <= BUpperLimit && customMarks >= BLowerLimit)
                    {
                        Console.WriteLine("The grade is B");
                    }
                }

                if (CUpperLimit != -1)
                {
                    if (customMarks <= CUpperLimit && customMarks >= CLowerLimit)
                    {
                        Console.WriteLine("The grade is A");
                    }
                }

                if (DUpperLimit != -1)
                {
                    if (customMarks <= DUpperLimit && customMarks >= DLowerLimit)
                    {
                        Console.WriteLine("The grade is D");
                    }
                }

                if (EUpperLimit != -1)
                {
                    if (customMarks <= EUpperLimit && customMarks >= ELowerLimit)
                    {
                        Console.WriteLine("The grade is E");
                    }
                }

                if (FUpperLimit != -1)
                {
                    if (customMarks <= FUpperLimit && customMarks >= FLowerLimit)
                    {
                        Console.WriteLine("The grade is F");
                    }
                }

                if (UUpperLimit != -1)
                {
                    if (customMarks <= UUpperLimit && customMarks >= ULowerLimit)
                    {
                        Console.WriteLine("The grade is U");
                    }
                }
            }
            else if (tresholdType == "default")
            {
                Console.Write("Enter marks: ");
                marks = Convert.ToInt32(Console.ReadLine());
                
                if (marks <= 100 && marks >= 90)
                {
                    Console.WriteLine("The grade is A*");
                }
                else if (marks <= 89 && marks >= 80)
                {
                    Console.WriteLine("The grade is A");
                }
                else if (marks <= 79 && marks >= 70)
                {
                    Console.WriteLine("The grade is B");
                }
                else if (marks <= 69 && marks >= 60)
                {
                    Console.WriteLine("The grade is C");
                }
                else if (marks <= 59 && marks >= 50)
                {
                    Console.WriteLine("The grade is D");
                }
                else if (marks <= 49 && marks >= 40)
                {
                    Console.WriteLine("The grade is E");
                }
                else if (marks <= 39 && marks >= 0)
                {
                    Console.WriteLine("The grade is F");
                }
                else
                {
                    Console.WriteLine("Please enter the marks between 0 and 100");
                }
            }
        }

        public static void SqaurePerimeter(double length)
        {
            double perimeter;
            perimeter = 4 * length;
            Console.WriteLine(perimeter);

        }

        public static void SquareArea(double length)
        {
            double area;
            area = length * length;
            Console.WriteLine(area);

        }

        public static void TrianglePerimeter(double Tbase, double Theight, double Thypotenuse)
        {
            double perimeter;
            perimeter = Tbase + Theight + Thypotenuse;
            Console.WriteLine(perimeter);

        }

        public static void TriangleArea(double Tbase, double Theight)
        {
            double area;
            area = (Theight * Tbase) / 2;
            Console.WriteLine(area);

        }

        public static void CircleCircumference(double radius) 
        {
            double circumference;
            circumference = 2 * Math.PI * radius;
            Console.WriteLine(circumference);

        }

        public static void CircleArea(double radius)
        {
            double area;
            area = Math.PI * radius * radius;
            Console.WriteLine(area);

        }

        public static void CylinderArea(double radius, double height)
        {
            double area;
            area = Math.PI * radius * radius * height;
            Console.WriteLine(area);

        }


    }
}