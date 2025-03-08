// See https://aka.ms/new-console-template for more information
// สร้างอ็อบเจ็กต์ของคลาสลูก
var circle = new Circle();
var rectangle = new Rectangle();
var triangle = new Triangle();

class Shape
{
    private int? NumOfSide;

    // เปลี่ยนจาก private เป็น protected เพื่อให้คลาสลูกสามารถเข้าถึงได้
    protected Shape()
    {
    }

    public Shape(int NumOfSide) : this() // เรียกใช้คอนสตรักเตอร์หลัก
    {
        this.NumOfSide = NumOfSide;
        System.Console.WriteLine($"This is some shape with {NumOfSide} sides");
    }
}

class Circle : Shape
{
    public Circle() : base(0) // กำหนดว่ารูปวงกลมมี 0 ด้าน
    {
        System.Console.WriteLine("This is a circle");
    }
}

class Rectangle : Shape
{
    public Rectangle() : base(4) // สี่เหลี่ยมมี 4 ด้าน
    {
        System.Console.WriteLine("This is a rectangle");
    }
}

class Triangle : Shape
{
    public Triangle() : base(3) // สามเหลี่ยมมี 3 ด้าน
    {
        System.Console.WriteLine("This is a triangle");
    }
}

