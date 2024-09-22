using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(3); //Creates an object called circle using abstract class Shape then calling inheritted class; using parameters defined in child class for variables
            Shape rectangle = new Rectangle(3, 4); //Creates an object called rectangle using abstract class Shape then calling respected inheritted class; using parameters defined in child class for variable
            Shape triangle = new Triangle(3, 4); //Creates an object called triangle using abstract class Shape then calling respected inheritted class; using parameters defined in child class for variable

            Console.WriteLine(circle.CalculateArea) //Outputs the answer with formula of each respected CalculateArea()
            Console.WriteLine(rectangle.CalculateArea) //Outputs the answer with formula of each respected CalculateArea()
            Console.WriteLine(triangle.CalculateArea) //Outputs the answer with formula of each respected CalculateArea()
            Console.ReadLine(); //Pauses program to allow user to see output
        }
        //Abstract Shape class that shares a method across child classes
        abstract class Shape
        {
            public abstract double CalculateArea(); //CalculateArea is a shared method to avoid repetition
        }
        //Class Circle inherits from Abstract Class Shape
        class Circle : Shape
        {
            double Radius = 0; //Set variable to hold value 
            public Circle(double r) //Gets Radius variable from parameter
            {
                Radius = r;
            }
            public override double CalculateArea() //Calculates area of a cirlce: Pi*r squared and returns as a variable called area
            {
                double area = Radius * Radius * Math.PI;
                return area;
            }
        }
        //Class Rectangle inherits from Abstract Class Shape
        class Rectangle : Shape
        {
            //Set 2 variables to hold value
            double Width = 0;
            double Height = 0;
            public Rectangle(double w, double h) //Gets width and height from parameters
            {
                Width = w;
                Height = h;
            }
            public override double CalculateArea() //Calculates area of a cirlce: Width*height and returns as a variable called area
            {
                double area = Width * Height;
                return area;
            }
        }
        //Class Triangle inherits from Abstract Class Shape
        class Triangle : Shape
        {
            //Set 2 variables to hold value
            double Base = 0;
            double Height = 0;
            public Triangle(double b, double h) //Gets base and height from parameters
            {
                Base = b;
                Height = h;
            }
            public override double CalculateArea() //Calculates area of a triangle: 0.5*base*height and returns as a variable called area
            {
                double area = 0.5 * Base * Height;
                return area;
            }
        }
    }
}
