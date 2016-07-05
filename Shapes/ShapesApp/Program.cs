using ShapeLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeManager shapes = new ShapeManager();
            shapes.Add(new Rectangle(10, 20) { Color = ConsoleColor.Blue });
            shapes.Add(new Ellipse(5, 7) { Color = ConsoleColor.Red });
            shapes.Add(new Circle(5));
            Console.WriteLine($"Count of shapes in this array is: {shapes.Count}\n");
            shapes.DisplayAll();

            StringBuilder sb = new StringBuilder();
            shapes.Save(sb);
            Console.WriteLine(sb.ToString());

            Rectangle rec = new Rectangle(8, 9);
            Rectangle rec2 = new Rectangle(8, 7);
            Console.WriteLine("\nWhich rectangle is bigger: " + rec.CompareTo(rec2));

            Ellipse ellipse = new Ellipse(1, 3);
            Ellipse ellipse2 = new Ellipse(4, 8);
            Console.WriteLine("Which wllipse is bigger: " + ellipse.CompareTo(ellipse2));
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
                Console.WriteLine("-------------------------------------------------");
            }

        }
        public void Save(StringBuilder sb)
        {
            foreach (var shape in array)
            {
                IPersist ipersist = (shape as IPersist);
                if (ipersist != null)
                    ipersist.Write(sb);
            }

        }
        public Shape this[int index]   // Indexer declaration
        {
            get
            {
                return array[index];
            }
        }
        public int Count
        {
            get
            {
                return array.Count;
            }
        }
    }
}
