public class Square : Shape
{
    // this is a field
    private double _side;

    // this is a constructor
    public Square(double side) {
        _side = side;
    }

    // this is a method
    public override double Area() => _side * _side;

    public double Perimeter() => _side * 4;

}

