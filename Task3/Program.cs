Circle circle = new Circle(5);
Rectangle rectangle = new Rectangle(3, 6);
Console.WriteLine(SquareOf(circle));
Console.WriteLine(SquareOf(rectangle));

double SquareOf(ISquareable squareable) => squareable.Square();

interface ISquareable
{
    double Square();
}

class Circle : ISquareable
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Square()
    {
        return 3.14 * Radius * Radius;
    }
}

class Rectangle : ISquareable
{
    public double a;
    public double b;

    public Rectangle(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public double Square()
    {
        return a * b;
    }
}