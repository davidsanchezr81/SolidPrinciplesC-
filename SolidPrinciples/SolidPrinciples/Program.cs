using System;
using System.Collections.Generic;

namespace SolidPrinciples
{
    class Program
    {
        private static void Main(string[] args)
        {
            var rectangulos = new[]
            {

                new Rectangle {Width = 10, Height = 5},
                new Rectangle {Width = 4, Height = 6},
                new Rectangle {Width = 5, Height = 1},
                new Rectangle {Width = 8, Height = 9},
            };

            var sumaDeAreas = Rectangle.SumAreas(rectangulos);
            var sumaDePerimetros = Rectangle.SumPerimeters(rectangulos);

            Console.WriteLine($"Areas total: {sumaDeAreas} " + $"\nPerimetro total:{sumaDePerimetros}");

            Console.ReadKey();
        }
    }
}
