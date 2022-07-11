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
var badCalculator = new SRP.Bad.AreaCalculator(shapes);
Console.WriteLine(badCalculator.Output());


// good flow
var goodCalculator = new SRP.Good.AreaCalculator(shapes);
var outputter = new SRP.Good.SumCalculatorOutputter(goodCalculator);

Console.WriteLine(outputter.JSON());
Console.WriteLine(outputter.Message());

