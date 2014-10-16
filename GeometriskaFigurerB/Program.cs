using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurerB
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = RandomizeShapes();

            ViewShapes(shapes);

        }

        private static Shape[] RandomizeShapes()
        {
            Random random = new Random();

            int numberOfShapes = random.Next(5, 21);

            Shape[] shapeArray = new Shape[numberOfShapes];

            for (int i = 0; i < numberOfShapes; i++)
            {
                double length = random.Next(5, 100);
                double width = random.Next(5, 100);
                int randomShape = random.Next(0, 2);
                switch ((ShapeType)randomShape)
                {
                    case ShapeType.Ellipse:
                        shapeArray[i] = new Ellipse(length, width);
                        break;
                    case ShapeType.Rectangle:
                        shapeArray[i] = new Ellipse(length, width);
                        break;
                }
            }
            return shapeArray;
        }

        private static void ViewShapes(Shape[] shapes)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~¨~");
            Console.WriteLine("~\t     Detaljer     \t~");
            Console.WriteLine("~._._._._._._._._._._._._._._._.~");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Figur\tLängd\tBredd\tOmkrets\tArea");
            Console.WriteLine("============================================");

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i]);
            }
        }

    }
}
