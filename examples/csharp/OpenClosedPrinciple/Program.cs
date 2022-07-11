/**
Here is an example with a collection of three shapes:

a circle with a radius of 2
a square with a length of 5
a second square with a length of 6
**/


// bad flow
Console.WriteLine("Bad Flow");
List<object> shapes = new List<object> {
        new OCP.Bad.Circle(2),
        new OCP.Bad.Square(5),
        new OCP.Bad.Square(6)
    };

var badCalculator = new OCP.Bad.AreaCalculator(shapes);
var badOutputter = new OCP.Bad.SumCalculatorOutputter(badCalculator);

Console.WriteLine(badOutputter.JSON());
Console.WriteLine(badOutputter.Message());


// good flow
Console.WriteLine("Good Flow");

List<OCP.Good.IShape> gShapes = new List<OCP.Good.IShape> {
        new OCP.Good.Circle(2),
        new OCP.Good.Square(5),
        new OCP.Good.Square(6)
    };

var goodCalculator = new OCP.Good.AreaCalculator(gShapes);
var goodOutputter = new OCP.Good.SumCalculatorOutputter(goodCalculator);

Console.WriteLine(goodOutputter.JSON());
Console.WriteLine(goodOutputter.Message());

