namespace Model
{
    public class Square: IShape, IManageShape
    {
        public int Length { get; private set; }

        public Square(int length)
        {
            this.Length = length;
        }

        public double Area()
        {
            return this.Length * this.Length;
        }

        public double Calculate()
        {
            return this.Area();
        }
    }
}
