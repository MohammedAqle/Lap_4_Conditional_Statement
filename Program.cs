using System;
using System.ComponentModel.DataAnnotations;

namespace Lap_4_Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //f1();

            //2
            //f2();

            //3
            //f3();

            //4
            //f4();

            //5
            //f5();

            //6
            //f6();

            //7
            //f7();

            //8
            //f8();

            //9
            //f9();

            //10
            f10();


        }

        //1_Write a C# Sharp program to accept two integers and check whether they are equal or not.
        public static void f1()
        {
            Console.Write("Input 1st number: ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int value2 = int.Parse(Console.ReadLine());

            if (value1 == value2)
                Console.WriteLine($"{value1} and {value2} are equal");
            else
                Console.WriteLine($"{value1} and {value2} are not equal");
        }

        //2_Write a C# Sharp program to check whether a given number is even or odd.
        public static void f2()
        {
            Console.Write("Enter A number: ");
            int value = int.Parse(Console.ReadLine());

            if (value % 2 == 0)
                Console.WriteLine($"{value} is an even integer");
            else
                Console.WriteLine($"{value} is an odd integer");
        }

        //3_Write a C# Sharp program to check whether a given number is positive or negative. 
        public static void f3()
        {
            Console.Write("Test Data: ");
            int value = int.Parse(Console.ReadLine());

            if (value > 0)
                Console.WriteLine($"{value} is an positive number ");
            else
                Console.WriteLine($"{value} is an negative number ");
        }

        //4_ Write a C# Sharp program to find whether a given year is a leap year or not.
        public static void f4()
        {
            Console.Write("Test Data: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year))
                Console.WriteLine($"{year} is a leap year.");
            else
                Console.WriteLine($"{year} is not a leap year.");
        }

        //5_ Write a C# Sharp program to read the age of a candidate and determine whether it is
        //eligible for casting his/her own vote. 
        public static void f5()
        {
            Console.WriteLine("Test Data : ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            else
                Console.WriteLine("Sorry! You are not eligible for casting your vote.");
        }

        //6_ Write a C# Sharp program to read the value of an integer m and display the value of 
        //n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0. 
        public static void f6()
        {
            Console.WriteLine("Test Data: ");
            int value = int.Parse(Console.ReadLine());

            if (value > 0)
                Console.WriteLine("The value of n = 1");
            else if (value == 0)
                Console.WriteLine("The value of n = 0");
            else if (value < 0)
                Console.WriteLine("The value of n = -1");

        }

        //7_Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
        public static void f7()
        {
            Console.Write("Test Data : ");
            int value = int.Parse(Console.ReadLine());

            if (value >= 165)
                Console.WriteLine("The person is Tall.");
            else if (value < 165 && value >= 150)
                Console.WriteLine("The person is Average height.");
            else if (value < 150)
                Console.WriteLine("The person is Dwarf.");

        }

        //8_Write a C# Sharp program to find the largest of three numbers.
        public static void f8()
        {
            Console.Write("Input the 1st number :");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Input the 2nd number :");
            int value2 = int.Parse(Console.ReadLine());

            Console.Write("Input the 3rd number :");
            int value3 = int.Parse(Console.ReadLine());

            if (value1 > value2)
            {
                if (value1 > value3)
                    Console.WriteLine("The 1st Number is the greatest among three");
                else
                    Console.WriteLine("The 3rd Number is the greatest among three");
            }
            else
            {
                if (value2 > value3)
                    Console.WriteLine("The 2nd Number is the greatest among three");
                else
                    Console.WriteLine("The 3rd Number is the greatest among three");
            }
        }

        //9_Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        public static void f9()
        {
            Console.Write("Input the value for X coordinate :");
            int Xvalue = int.Parse(Console.ReadLine());
            Console.Write("Input the value for X coordinate :");
            int Yvalue = int.Parse(Console.ReadLine());

            if (Xvalue > 0 && Yvalue > 0)
                Console.WriteLine($"The coordinate point ({Xvalue},{Yvalue}) lies in the First quadrant.");
            else if (Xvalue < 0 && Yvalue < 0)
                Console.WriteLine($"The coordinate point ({Xvalue},{Yvalue}) lies in the Thired quadrant.");
            else if (Xvalue > 0 && Yvalue < 0)
                Console.WriteLine($"The coordinate point ({Xvalue},{Yvalue}) lies in the Fourth quadrant.");
            else if (Xvalue < 0 && Yvalue > 0)
                Console.WriteLine($"The coordinate point ({Xvalue},{Yvalue}) lies in the Secand quadrant.");
            else
                Console.WriteLine($"The coordinate point ({Xvalue},{Yvalue}) lies in the Origin.");

        }

        //10_ Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria:
        public static void f10()
        {
            Console.Write("Input the marks obtained in Physics :");
            int PhyMark = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry :");
            int ChemMark = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Mathematics :");
            int MathMark = int.Parse(Console.ReadLine());

            if (MathMark >= 140 || (MathMark >= 65 && PhyMark >= 55 && ChemMark >= 50))
                Console.WriteLine("The candidate is eligible for admission.");
            else
                Console.WriteLine("The candidate is not eligible for admission.");

        }

        //11_Write a C# Sharp program to calculate root of Quadratic Equation.
        public static void f11()
        {

        }

    }
}
