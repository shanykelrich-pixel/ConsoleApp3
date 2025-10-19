using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Circle : Shape
	{
		private double radius;

		public double Radius
		{
			get { return radius; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("Radius cannot be negative");
				}

				radius = value;
			}
		}




		public Circle(string Color, double radius) : base(Color)
		{
			Radius = radius;
		}
		public override double Area()
		{
			return Math.PI * Radius * Radius;
		}
		public override double Perimeter()
		{
			return 2 * Math.PI * Radius;
		}
	}
}
	
