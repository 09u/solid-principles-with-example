/**
Here is an example with a collection of three shapes:

a circle with a radius of 2
a square with a length of 5
a second square with a length of 6
**/

// bad flow
Console.WriteLine("Bad Flow");
List<ISP.Bad.IShape> shapes = new List<ISP.Bad.IShape> {
        new ISP.Bad.Circle(2),
        new ISP.Bad.Square(5),
        new ISP.Bad.Square(6)
    };

var badCalculator = new ISP.Bad.AreaCalculator(shapes);
var badOutputter = new ISP.Bad.SumCalculatorOutputter(badCalculator);

var badVolumeCalculator = new ISP.Bad.VolumeCalculator(shapes);
var badVolumeOutputter = new ISP.Bad.SumCalculatorOutputter(badVolumeCalculator);

Console.WriteLine(badOutputter.JSON());
Console.WriteLine(badOutputter.Message());
Console.WriteLine(badVolumeOutputter.JSON());
Console.WriteLine(badVolumeOutputter.Message());


// good flow
Console.WriteLine("Good Flow");

List<ISP.Good.IShape> gShapes = new List<ISP.Good.IShape> {
        new ISP.Good.Circle(2),
        new ISP.Good.Square(5),
        new ISP.Good.Square(6),
        new ISP.Good.Cube(5)
    };

var goodAreaCalculator = new ISP.Good.AreaCalculator(gShapes);
var goodAreaOutputter = new ISP.Good.SumCalculatorOutputter(goodAreaCalculator);

var goodVolumeCalculator = new ISP.Good.VolumeCalculator(gShapes);
var goodVolumeOutputter = new ISP.Good.SumCalculatorOutputter(goodVolumeCalculator);

Console.WriteLine(goodAreaOutputter.JSON());
Console.WriteLine(goodAreaOutputter.Message());
Console.WriteLine(goodVolumeOutputter.JSON());
Console.WriteLine(goodVolumeOutputter.Message());
