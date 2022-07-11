/**
Here is an example with a collection of three shapes:

a circle with a radius of 2
a square with a length of 5
a second square with a length of 6
**/

List<object> shapes = new List<object> {
        new SRP.Bad.Circle(2),
        new SRP.Bad.Square(5),
        new SRP.Bad.Square(6)
    };


// bad flow
Console.WriteLine("Bad Flow");
var badCalculator = new SRP.Bad.AreaCalculator(shapes);
Console.WriteLine(badCalculator.Output());


// good flow
Console.WriteLine("Good Flow");

List<object> gShapes = new List<object> {
        new SRP.Good.Circle(2),
        new SRP.Good.Square(5),
        new SRP.Good.Square(6)
    };

var goodCalculator = new SRP.Good.AreaCalculator(gShapes);
var outputter = new SRP.Good.SumCalculatorOutputter(goodCalculator);

Console.WriteLine(outputter.JSON());
Console.WriteLine(outputter.Message());

