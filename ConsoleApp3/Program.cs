using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Shape[] shapes = new Shape[3];
            shapes[0] = new Circle("Red", 5);
            shapes[1] = new Rectangle("Blue", 4, 6);
            shapes[2] = new Square("Green", 4);

            Console.WriteLine(((Circle)shapes[0]).Area());
            Console.WriteLine(((Circle)shapes[0]).Perimeter());
            Console.WriteLine(((Rectangle)shapes[1]).Perimeter());
            Console.WriteLine(((Rectangle)shapes[1]).Area());
            Console.WriteLine(((Square)shapes[2]).Area());
            Console.WriteLine(((Square)shapes[2]).Perimeter());


        }
    }
}
