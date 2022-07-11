using System;
using System.Text.Json;
using Model;

namespace SRP.Good
{
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
