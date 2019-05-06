using System;
using System.Collections.Generic;

namespace SolidPrinciples
{
    public class PerimeterOperations
    {
        public static double Sum(IEnumerable<Rectangle> rectangles)

        {
            double perimeter = 0;
            foreach (var rectangle in rectangles)
                perimeter += 2 * rectangle.Height + 2 * rectangle.Width;
            return perimeter;
        }
    }
}
