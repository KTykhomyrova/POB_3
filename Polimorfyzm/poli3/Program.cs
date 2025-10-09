using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poli3
{
    internal class Program
    {

        abstract class Shape
        {
            public abstract void GetArea();  
        }

        class Circle : Shape
        {
            public override void GetArea()
            {
                Console.WriteLine("Podaj radius");
                int r = int.Parse(Console.ReadLine());
                Console.WriteLine($"Pole kola: {Math.PI*r*r}");
            }
        }

        class Rectangle : Shape
        {
            public override void GetArea()
            {
                Console.WriteLine("Podaj 1 i 2 bok");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"Pole prostokata: {a*b}");
            }
        }
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Rectangle rectangle = new Rectangle();

            Shape[] shapes = { c, rectangle };

            foreach (var item in shapes)
            {
                item.GetArea();
            }
        }
    }
}
