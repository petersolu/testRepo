using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olu2019TestProject
{
    public class triangle
    {
        public int triHeight;
        public int triBase;
        public int areaAnswer;

        public void TriangleArea()
        {
            areaAnswer = triHeight * triBase;
            Console.WriteLine("The area of this triangle is {0}", areaAnswer);
        }

        public int SquareArea()
        {
            areaAnswer = (triBase + triHeight) * 2;
            Console.WriteLine("The square root of this triangle is {0}", areaAnswer);
            return areaAnswer;
        }

        public void PolygonArea(int parameterOne, int parameterTwo)
        {
            Console.WriteLine();
            triHeight = parameterOne;
            triBase = parameterTwo;
            areaAnswer = parameterOne / parameterTwo;
            Console.WriteLine("The area of this polygon is {0}", areaAnswer);
        }
    }
}
