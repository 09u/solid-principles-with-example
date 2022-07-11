using System;
using System.Text.Json;

namespace LSP.Bad
{
    public interface IShape
    {
        double Area();
    }

    public class Circle: IShape
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
    }

    public class Square: IShape
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

    }

    public class AreaCalculator
    {
        private List<IShape> shapes = null;
        public AreaCalculator(List<IShape> shapes)
        {
            this.shapes = shapes;
        }

        public double Sum()
        {
            double sumArea = 0.0;
            
            foreach (var shape in this.shapes)
                if (shape is IShape)
                    sumArea += shape.Area();
                else
                    throw new Exception("Unsuitable Class");
            
            return sumArea;
        }
    }

    public class SumCalculatorOutputter
    {
        private AreaCalculator calculator;

        public SumCalculatorOutputter(AreaCalculator calculator)
        {
            this.calculator = calculator;
        }

        public string JSON()
        {
            // create object
            var response = new {
                sum = this.calculator.Sum()
            };

            return JsonSerializer.Serialize(response);
        }

        public string Message()
        {
            return String.Format("Sum of the areas of provided shapes: {0:0.00}", 
                this.calculator.Sum());
        }
    }
}
