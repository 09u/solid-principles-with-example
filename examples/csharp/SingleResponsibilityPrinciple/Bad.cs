using System;

namespace SRP.Bad
{
    public class Circle
    {
        public int Radius { get; private set; }

        public Circle(int radius)
        {
            this.Radius = radius;
        }
    }

    public class Square
    {
        public int Length { get; private set; }

        public Square(int length)
        {
            this.Length = length;
        }
    }

    class AreaCalculator
    {
        private List<object> shapes = null;
        public AreaCalculator(List<object> shapes)
        {
            this.shapes = shapes;
        }

        public double Sum()
        {
            double sumArea = 0.0;

            if (this.shapes == null)
                return 0;
            
            foreach (var shape in this.shapes)
            {
                if (shape.GetType() == typeof(Square))
                    sumArea += Math.Pow(((Square)shape).Length, 2);

                if (shape.GetType() == typeof(Circle))
                    sumArea += Math.PI * Math.Pow(((Circle)shape).Radius, 2);
            }
            
            return sumArea;
        }

        public string Output()
        {
            return String.Format("Sum of the areas of provided shapes: {0:0.00}", this.Sum());
        }
    }
}
