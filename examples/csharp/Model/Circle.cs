using System;

namespace Model
{
    public class Circle: IShape, IManageShape
    {
        public int Radius { get; private set; }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public double Calculate()
        {
            return this.Area();
        }
    }
}
