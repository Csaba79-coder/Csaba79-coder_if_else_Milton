using System;

namespace Csaba79_coder_if_else_Milton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("\tHello Michael \"Air\" Jordan!");

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hey, " + name + "!");

            int a, b;
            Console.WriteLine("Please enter a number: "); // if I use Console.Write it will write in the same line, not in a next one!
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("The sum of two nums are: " + c);

            Console.WriteLine("The value of a is: {0}, value of b: {1} and division of them is: {2}", a, b, a / b);
            Console.WriteLine("The value of a is: {0}, value of b: {1} and division of them is: {2}", a, b, Convert.ToDouble(a) / Convert.ToDouble(b));

            double area = Math.Sqrt(3) / 2 * a * a; // double area = Math.Sqrt(3) /* 2 * Math.Pow(a, 2);
            Console.WriteLine("The area of triangle is: " + area);
            double areaOfSquare = Math.Pow(b, 2);
            Console.WriteLine("The area of sqaure is: " + areaOfSquare);

            if (area > areaOfSquare) Console.WriteLine("The area of the triangle is bigger than the square's!");
            else if (area < areaOfSquare) Console.WriteLine("The squre is bigger!");
            else Console.WriteLine("The area of triangle and square are the same!");

            if (area > 9)
            {
                Console.WriteLine("c is smaller than 9");
            }
            else if (area == areaOfSquare)
            {
                Console.WriteLine("The area of triangle and square are the same!");
            }
            else
            {
                Console.WriteLine("c is bigger than 9");
            }

            double roundedTriangleArea = Math.Round(area);
            double rondedSquareArea = Math.Round(areaOfSquare);
            Console.WriteLine("The rounded area of triange is: " + roundedTriangleArea);
            Console.WriteLine("The rounded area of square is: " + rondedSquareArea);

            int[] array = new int[6] { 1, 2, 3, 4, 5, 6 };
            Console.Write("The first element of array on the index {0} is " + array[0] + "\n");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("The {0}. element of the  array is {1}", i + 1, array[i] + "\n");
            }
        }
    }
}
