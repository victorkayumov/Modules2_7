using System;
using System.Text;

namespace ShapeLib
{
    public interface IPersist
    {
        void Write(StringBuilder sb);
    }

    public abstract class Shape
    {
        public ConsoleColor Color { get; set; }

        public abstract double Area { get; }

        public Shape()//Default constructor
        {
            Color = ConsoleColor.White;
        }

        public Shape(ConsoleColor color)
        {
            Color = color;
        }

        public virtual void Display()
        {
            Console.BackgroundColor = Color;

        }
    }
    public class Rectangle : Shape, IPersist, IComparable
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }



        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }


        public override void Display()
        {
            base.Display();
            Console.WriteLine($"The Width of rectangle is: {Width}");
            Console.WriteLine($"The Height of rectangle is: {Height}");
        }
        //-----------------------------------------------------------------------------------------//
        public void Write(StringBuilder sb)
        {
            sb.Append("Widht: " + Width.ToString() + "\t");
            sb.Append("Height: " + Height.ToString() + "\t");
        }

        public int CompareTo(object obj)
        {
            Rectangle rec = (Rectangle)obj;

            return this.Area.CompareTo(rec.Area);
        }
        //-----------------------------------------------------------------------------------------//
    }
    public class Ellipse : Shape, IPersist, IComparable
    {
        public int SmallRadius { get; set; }
        public int BigRadius { get; set; }

        public Ellipse(int smallRadius, int bigRadius)
        {
            SmallRadius = smallRadius;
            BigRadius = bigRadius;
        }
        public override double Area
        {
            get
            {
                Console.WriteLine($"The SmallRadius of Ellipse is: {SmallRadius}");
                Console.WriteLine($"The BigRadius of Ellipse is: {BigRadius}");
                return Math.PI * SmallRadius * BigRadius;
            }
        }

        public override void Display()
        {

            base.Display();
        }
        //-----------------------------------------------------------------------------------------//
        public void Write(StringBuilder sb)
        {
            sb.Append("SmallRadius: " + SmallRadius.ToString() + "\t");
            sb.Append("BigRadius: " + BigRadius.ToString() + "\t");
        }

        public int CompareTo(object obj)
        {
            Ellipse ellipse = (Ellipse)obj;

            return this.Area.CompareTo(ellipse.Area);
        }
        //-----------------------------------------------------------------------------------------//
    }

    public class Circle : Ellipse
    {
        public Circle(int radius) : base(radius, radius)
        {
        }
        public override double Area
        {
            get
            {
                return Math.PI * SmallRadius * BigRadius;
            }
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"The Radius of Circle is: {BigRadius}");
        }
    }
}
