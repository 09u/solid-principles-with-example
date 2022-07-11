/**
Here is an example with a collection of three shapes:

a circle with a radius of 2
a square with a length of 5
a second square with a length of 6
**/

Console.WriteLine("Bad Flow");
List<LSP.Bad.IShape> shapes = new List<LSP.Bad.IShape> {
        new LSP.Bad.Circle(2),
        new LSP.Bad.Square(5),
        new LSP.Bad.Square(6)
    };

var badCalculator = new LSP.Bad.AreaCalculator(shapes);
var badOutputter = new LSP.Bad.SumCalculatorOutputter(badCalculator);

Console.WriteLine(badOutputter.JSON());
Console.WriteLine(badOutputter.Message());


// good flow
Console.WriteLine("Good Flow");

List<LSP.Good.IShape> gShapes = new List<LSP.Good.IShape> {
        new LSP.Good.Circle(2),
        new LSP.Good.Square(5),
        new LSP.Good.Square(6)
    };

var goodAreaCalculator = new LSP.Good.AreaCalculator(gShapes);
var goodAreaOutputter = new LSP.Good.SumCalculatorOutputter(goodAreaCalculator);

var goodVolumeCalculator = new LSP.Good.VolumeCalculator(gShapes);
var goodVolumeOutputter = new LSP.Good.SumCalculatorOutputter(goodVolumeCalculator);

Console.WriteLine(goodAreaOutputter.JSON());
Console.WriteLine(goodAreaOutputter.Message());
Console.WriteLine(goodVolumeOutputter.JSON());
Console.WriteLine(goodVolumeOutputter.Message());
