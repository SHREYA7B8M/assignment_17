using assignment_17;
using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the radius of the Circle: ");
        double circleRadius = double.Parse(Console.ReadLine());
        Circle circle = new Circle(circleRadius);

        Console.WriteLine("Input the width of the Rectangle: ");
        double rectangleWidth = double.Parse(Console.ReadLine());

        Console.WriteLine("Input the height of the Rectangle: ");
        double rectangleHeight = double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(rectangleWidth, rectangleHeight);

        Console.WriteLine("Input the length of Side A of the Triangle: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.WriteLine("Input the length of Side B of the Triangle: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.WriteLine("Input the length of Side C of the Triangle: ");
        double sideC = double.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        circle.PrintInfo();
        rectangle.PrintInfo();
        triangle.PrintInfo();

        
    }
}
