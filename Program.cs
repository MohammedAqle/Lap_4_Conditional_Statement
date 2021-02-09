using System;

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
            //f10();

            //12
            //f12();

            //13
            //f13();

            //14
            //f14();

            //15
            //f15();

            //16
            //f16();

            //17
            //f17();

            //18
            //f18();

            //19
            //f19();

            //20
            //f20();

            //21
            //f21();

            //22
            //f22();

            //23
            //f23();

            //24
            //f24();

            //25
            f25();

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

        //12_Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
        public static void f12()
        {
            Console.Write("Input the Roll Number of the student :");
            int rollNumber = int.Parse(Console.ReadLine());

            Console.Write("Input the Name of the Student :");
            string StudentName = Console.ReadLine();

            Console.Write("Input  the marks of Physics : ");
            int phyMark = int.Parse(Console.ReadLine());

            Console.Write("Input  the marks of  Chemistry : ");
            int chemMark = int.Parse(Console.ReadLine());
            Console.Write("Input  the marks of Computer Application : ");
            int CAMark = int.Parse(Console.ReadLine());

            Console.WriteLine($"Roll No : {rollNumber}");
            Console.WriteLine($"Name of Student : {StudentName}");
            Console.WriteLine($"Marks in Physics : {phyMark}");
            Console.WriteLine($"Marks in Chemistry  : {chemMark}");
            Console.WriteLine($"Marks in Computer Application : {CAMark}");
            Console.WriteLine($"Total Marks = {phyMark + chemMark + CAMark}");
            Console.WriteLine($"Percentage = {(phyMark + chemMark + CAMark) / 3}");

        }

        //13_Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state
        public static void f13()
        {
            Console.Write("Enter Temperature ");
            float tem = float.Parse(Console.ReadLine());

            if (tem >= 40)
                Console.WriteLine("Its Very Hot");
            else if (tem > 30 && tem < 40)
                Console.WriteLine("Its Hot");
            else if (tem > 20 && tem < 30)
                Console.WriteLine("Normal in Temp");
            else if (tem > 10 && tem < 20)
                Console.WriteLine("Cold weather");
            else if (tem > 0 && tem < 10)
                Console.WriteLine("Very Cold weather");
            else if (tem < 0)
                Console.WriteLine("Freezing weather");
        }

        //14_Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
        public static void f14()
        {
            Console.Write("Enter the length of the first side : ");
            int firstSide = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the secand side : ");
            int secandSide = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the third side : ");
            int thirdSide = int.Parse(Console.ReadLine());

            if (firstSide == secandSide && secandSide == thirdSide)
                Console.WriteLine("This is an equilateral triangle.");
            else if (firstSide == secandSide || secandSide == thirdSide || firstSide == thirdSide)
                Console.WriteLine("This is an isosceles triangle.");
            else
                Console.WriteLine("This is an Scalene triangle.");

        }

        //15_Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles.
        public static void f15()
        {
            Console.Write("Enter The First angles : ");
            int firstAngle = int.Parse(Console.ReadLine());

            Console.Write("Enter The Secand angles : ");
            int SecandAngle = int.Parse(Console.ReadLine());

            Console.Write("Enter The Third angles : ");
            int ThirdAngle = int.Parse(Console.ReadLine());

            if (firstAngle + SecandAngle + ThirdAngle == 180)
                Console.WriteLine("The triangle is valid.");
            else
                Console.WriteLine("The triangle is not valid.");

        }

        //16_Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
        public static void f16()
        {
            Console.Write("Enter Alphabet : ");
            char alphabet = Console.ReadKey().KeyChar;

            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
                Console.WriteLine("\nThe alphabet is a vowel. ");
            else
                Console.WriteLine("\nThe alphabet is a consonant.");

        }

        //17_Write a C# Sharp program to calculate profit and loss on a transaction.
        public static void f17()
        {
            Console.Write("Enter first Transaction : ");
            int FirstTran = int.Parse(Console.ReadLine());

            Console.Write("Enter Secand Transaction : ");
            int SecandTran = int.Parse(Console.ReadLine());

            if (FirstTran - SecandTran < 0)
                Console.WriteLine($"You can book your profit amount : {Math.Abs(FirstTran - SecandTran)}");
            else
                Console.WriteLine($"You loss your profit amount : -{FirstTran - SecandTran}");

        }

        //18_Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
        public static void f18()
        {
            string CustomerID, CustomerName;
            double SurchargeAmount = 0, Charges = 0, ChargeUnites = 0;

            Console.WriteLine("Test Data :");
            Console.Write("Enter Customer id : ");
            CustomerID = Console.ReadLine();

            Console.Write("Enter Customer Name : ");
            CustomerName = Console.ReadLine();

            Console.Write("Enter Unites : ");
            int Unites = int.Parse(Console.ReadLine());

            Console.WriteLine($"Customer IDNO : {CustomerID}");
            Console.WriteLine($"Customer Name : {CustomerName}");
            Console.WriteLine($"unit Consumed : {Unites}");

            if (Unites >= 600)
            {
                Charges= 2.00;
                ChargeUnites = Charges * Unites;
            }
            else if (Unites >= 400 && Unites < 600)
            {
                Charges = 1.80;
                ChargeUnites = Charges * Unites;
            }
            else if (Unites >= 200 && Unites < 400)
            {
                Charges = 1.50;
                ChargeUnites = Charges * Unites;
            }
            else if (Unites<=199)
            {
                Charges = 1.20;
                ChargeUnites = Charges * Unites;
            }
            Console.WriteLine($"Amount Charges @Rs. {Charges} per unit : {ChargeUnites:f2}");

            if (ChargeUnites>400)
                SurchargeAmount = ChargeUnites * 0.15;
            Console.WriteLine($"Surcharge  Amount : {SurchargeAmount:f2}");

            Console.WriteLine($"Net Amount Paid By the Customer : {SurchargeAmount + ChargeUnites:F2}");

        }

        //19_Write a program in C# Sharp to accept a grade and declare the equivalent description :
        public static void f19()
        {
            Console.Write($"Input the grade :");
            char value = Console.ReadKey().KeyChar;

            if (value>=97&&value<=122)
            {
                value = char.ToUpper(value);

                Console.WriteLine();
                switch (value)
                {
                    case 'E':
                        Console.WriteLine("You have chosen: Excellent");
                        break;
                    case 'V':
                        Console.WriteLine("You have chosen: Very Good");
                        break;
                    case 'G':
                        Console.WriteLine("You have chosen: Good");
                        break;
                    case 'A':
                        Console.WriteLine("You have chosen: Average");
                        break;
                    case 'F':
                        Console.WriteLine("You have chosen: Fail");
                        break;
                    default:
                        break;
                }
            }
        }

        //20_ Write a program in C# Sharp to read any day number in integer and display day name in the word.
        public static void f20()
        {
            Console.Write("Enter Day Number: ");
            int value = int.Parse(Console.ReadLine());

            switch (value)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.Write("Invalid day number. \nPlease try again ....\n");
                    break;
            }
        }

        //21_Write a program in C# Sharp to read any digit, display in the word.
        public static void f21()
        {
            Console.Write("Enter number between 0-9 : ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    break;
            }
        }

        //22_Write a program in C# Sharp to read any Month Number in integer and display Month name in the word.
        public static void f22()
        {
            Console.Write("Enter Month Number : ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("Septemer");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    break;
            }
        }

        //23_ Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.
        public static void f23()
        {
            Console.Write("Enter Month Number : ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 2:
                    Console.WriteLine("Month have 29 days");
                    break;
                case 3:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 4:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 5:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 6:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 7:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 8:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 9:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 10:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 11:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 12:
                    Console.WriteLine("Month have 31 days");
                    break;
                default:
                    break;
            }
        }

        //24_Write a program in C# Sharp which is a Menu-Driven Program to compute the area of the various geometrical shape.
        public static void f24()
        {
            int choice, v1, v2;
            Console.WriteLine("A menu driven program to compute the area of various geometrical shape:");

            Console.WriteLine("Input 1 for area of circle");
            Console.WriteLine("Input 2 for area of rectangle");
            Console.WriteLine("Input 3 for area of triangle");
            Console.Write("Input your choice : ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Input radius of the circle : ");
                    v1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The area is : {3.14 * v1 * v1}");
                    break;
                case 2:
                    Console.WriteLine("Input length  of the rectangle : ");
                    v1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input width of the rectangle : ");
                    v2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The area is : {v1 * v2}");
                    break;
                case 3:
                    Console.WriteLine("Input the base of the triangle: ");
                    v1 = int.Parse(Console.ReadLine());
                    Console.Write("Input the hight of the triangle :");
                    v2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The area is : {.5 * v1 * v2}");
                    break;
                default:
                    break;
            }
        }

        //25_ Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.
        public static void f25()
        {
            int firstValue, secandValue, choice;
            Console.Write("Enter the first Integer : ");
            firstValue = int.Parse(Console.ReadLine());
            Console.Write("Enter the second Integer : ");
            secandValue = int.Parse(Console.ReadLine());

            Console.WriteLine("\nHere are the options :");
            Console.WriteLine("1-Addition.");
            Console.WriteLine("2-Substraction.");
            Console.WriteLine("3-Multiplication.");
            Console.WriteLine("4-Division.");
            Console.WriteLine("5-Exit.");

            Console.Write("\nInput your choice : ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"The Addition of {firstValue} and {secandValue} is: {firstValue + secandValue}");
                    break;
                case 2:
                    Console.WriteLine($"The Substraction of {firstValue} and {secandValue} is: {firstValue - secandValue}");
                    break;
                case 3:
                    Console.WriteLine($"The Multiplication of {firstValue} and {secandValue} is: {firstValue * secandValue}");
                    break;
                case 4:
                    Console.WriteLine($"The Division of {firstValue} and {secandValue} is: {firstValue / secandValue}");
                    break;
                case 5:
                    Console.WriteLine($"Exit Program.....");
                    break;
                default:
                    break;
            }



        }

    }
}
