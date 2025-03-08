// See https://aka.ms/new-console-template for more information
var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;

    // Constructor ปกติ ที่ให้คลาสลูกเรียกใช้
    protected Shape()
    {
        System.Console.WriteLine("This is some shape with unknown sides");
    }

    public Shape(int NumOfSide)
    {
        this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base() // เรียกคอนสตรักเตอร์แบบไม่มีพารามิเตอร์ของ Shape
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4)
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3)
    {
        System.Console.WriteLine("This is a triangle");
    }
}
