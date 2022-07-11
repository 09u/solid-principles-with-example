using Model;


/**
Here is an example with a collection of three shapes:

a circle with a radius of 2
a square with a length of 5
a second square with a length of 6
**/

List<IShape> shapes = new List<IShape> {
        // new Circle(2),
        // new Square(5),
        // new Square(6),
        new Cube(2)
    };


// bad flow
Console.WriteLine("Bad Flow");
var badCalculator = new LSP.Bad.AreaCalculator(shapes);
var badOutputter = new LSP.Bad.SumCalculatorOutputter(badCalculator);

Console.WriteLine(badOutputter.JSON());
Console.WriteLine(badOutputter.Message());


// good flow
Console.WriteLine("Good Flow");

var goodVolumeCalculator = new LSP.Good.VolumeCalculator(shapes);
var goodOutputter = new LSP.Good.SumCalculatorOutputter(goodVolumeCalculator);

Console.WriteLine(goodOutputter.JSON());
Console.WriteLine(goodOutputter.Message());
