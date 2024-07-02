namespace VS_SolidPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();

            AreaCalculator areaCalculatorV2 = new AreaCalculator();

            Circle circle = new Circle(radius: 10);
            Square square = new Square(length: 10);

            ShapesPrinter printer = new ShapesPrinter(areaCalculatorV2);
            Shape noShape = new NoShape();

            List<IShape> shapes = [];

            shapes.Add(circle);
            shapes.Add(square);

            double sum = areaCalculator.Sum(shapes);

            Console.WriteLine(printer.Json(shapes));
            Console.WriteLine(printer.Csv(shapes));

        }
    }
}
