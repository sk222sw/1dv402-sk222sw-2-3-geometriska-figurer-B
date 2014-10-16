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

    }
}
