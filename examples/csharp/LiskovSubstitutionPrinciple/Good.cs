using System;
using System.Text.Json;

namespace LSP.Good
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
        protected List<IShape> shapes = null;
        public AreaCalculator(List<IShape> shapes)
        {
            this.shapes = shapes;
        }

        public virtual double Sum()
        {
            double sumArea = 0.0;

            if (this.shapes == null)
                return 0;
            
            foreach (IShape shape in this.shapes)
            {
                if (shape is Square)
                    sumArea += Math.Pow(((Square)shape).Length, 2);
                if (shape is Circle)
                    sumArea += Math.PI * Math.Pow(((Circle)shape).Radius, 2);
            }
            
            return sumArea;
        }
    }

    public class VolumeCalculator: AreaCalculator
    {
        // private List<IShape> shapes;

        public VolumeCalculator(List<IShape> shapes) : base(shapes)
        {
            // this.shapes = shapes;
        }

        public override double Sum()
        {
            double sumVol = 0.0;
            
            foreach (var shape in this.shapes)
                if(shape is IShape)
                    sumVol += 0;
                else
                    throw new Exception("Not IShape class");

            return sumVol;
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
