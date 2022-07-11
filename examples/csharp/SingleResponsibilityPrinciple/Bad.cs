using System;
using Model;

namespace SRP.Bad
{
    class AreaCalculator
    {
        private List<IShape> shapes = null;
        public AreaCalculator(List<IShape> shapes)
        {
            this.shapes = shapes;
        }

        public double Sum()
        {
            double sumArea = 0.0;

            if (this.shapes == null)
                return 0;
            
            foreach (IShape shape in this.shapes)
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
