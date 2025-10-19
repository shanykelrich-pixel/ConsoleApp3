using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Shape
    {
        public string color { get; set; }
        public Shape(string color)
        {
            this.color = color;
        }
        public virtual double Area()
        {
            return 0;//
        }
        public virtual double Perimeter()
        {
            return 0;
        }
    }
}
