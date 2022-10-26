public class Circle : Shape
{
    private int _radius;

    public Circle(int radius)
    {
        _radius = radius;
    }

    public override double Area() => MathHelper.PI * MathHelper.power(_radius, 2);

    // getter
    public int GetRadius() => _radius;

    // setter
    public void SetRadius(int radius)
    {
        _radius = radius;
    } 
}