using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriskaFigurerB
{
    enum ShapeType
    {
        Ellipse,
        Rectangle,
    }

    public abstract class Shape : Object, IComparable
    {
        private double _length;     //representerar en figurs längd.
        private double _width;      //representerar en figurs bredd.

        public abstract double Area { get; } //representerar en figurs area

        public double Length        //kapslar in _length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _length = value;

            }    //set kastar undantag om värdet är mindre än 0.
        }

        public abstract double Perimeter { get; }    //representerar en figurs omkrets.

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _width = value;
            }
        }       //kapslar in _width

        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            
            return string.Format("{}{}{}{}{}",
            this.GetType, Length, Width, Perimeter, Area);
            //Figurens typ ges av metoden GetType(), som ärvs från klassen Object, och 
            //egenskapen Name.

        }



        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
