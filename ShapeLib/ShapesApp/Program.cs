using ShapeLib;
using System;
using System.Collections.Generic;


namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager shapes = new ShapeManager();
            shapes.Add(new Rectangle(10, 20));
            shapes.Add(new Ellipse(5, 7) { Color = ConsoleColor.Blue });
            shapes.Add(new Circle(5) { Color = ConsoleColor.Red });
            Console.WriteLine($"Count of shapes in this array is: {shapes.Count}\n");
            shapes.DisplayAll();
        }
    }
    public class ShapeManager
    {
        List<Shape> array = new List<Shape>();
        public void Add(Shape newShape)
        {
            array.Add(newShape);
        }
        public void DisplayAll()
        {
            foreach (var shape in array)
            {
                shape.Display();
                Console.WriteLine($"The area is : {shape.Area}");
            }

        }
        public Shape this[int index]   // Indexer declaration
        {
            get
            {
                return array[index];
            }
        }
        public int Count { get { return array.Count; } }
    }
}
