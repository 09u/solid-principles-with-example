using System;

namespace Model
{
    public class Cube: IShape, IThreeDimensionalShape, IManageShape
    {
        public int Length { get; private set; }

        public Cube(int length)
        {
            this.Length = length;
        }

        public double Area()
        {
            return 6 * Math.Pow(this.Length, 2);
        }

        public double Volume()
        {
            return Math.Pow(this.Length, 3);
        }

        public double Calculate()
        {
            return this.Area();
        }
    }
}
