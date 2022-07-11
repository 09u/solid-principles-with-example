using Model;


/**
Here is an example with a collection of three shapes:

a circle with a radius of 2
a square with a length of 5
a second square with a length of 6
**/

List<IShape> shapes = new List<IShape> {
        new Circle(2),
        new Square(5),
        new Square(6)
    };


// bad flow
var badCalculator = new OCP.Bad.AreaCalculator(shapes);
var badOutputter = new OCP.Bad.SumCalculatorOutputter(badCalculator);

Console.WriteLine(badOutputter.JSON());
Console.WriteLine(badOutputter.Message());


// good flow
var goodCalculator = new OCP.Good.AreaCalculator(shapes);
var goodOutputter = new OCP.Good.SumCalculatorOutputter(goodCalculator);

Console.WriteLine(goodOutputter.JSON());
Console.WriteLine(goodOutputter.Message());

