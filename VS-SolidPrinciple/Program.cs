namespace VS_SolidPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            Circle circle = new Circle(radius: 10);
            Square square = new Square(length: 10);

            List<object> shapes = new List<object>();

            shapes.Add(circle);
            shapes.Add(square);

            double sum = areaCalculator.Sum(shapes);
            Console.WriteLine($"sum = {sum}");

        }
    }
}
