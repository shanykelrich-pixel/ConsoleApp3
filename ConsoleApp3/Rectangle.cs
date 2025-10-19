using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 
{
    internal class Rectangle : Shape
    {
        


            public Rectangle(string Color, double width, double length) : base(Color)
            {

            }
            private double length;
            private double width;

            public override double Area()
            {
                return Length * Width;
            }
            public override double Perimeter()
            {
                return 2 * (Length + Width);
            }

            public double Length
            {
                get { return length; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Length cannot be negative");
                    }
                    Length = value;

                }
            }
            public double Width
            {
                get { return width; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Width cannot be negative");
                    }
                    Width = value;
                }

            }
        }
    }

