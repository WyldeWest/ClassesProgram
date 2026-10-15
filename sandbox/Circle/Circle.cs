using System.Runtime.CompilerServices;

class Circle
{
    private double _radius;

    public Circle()
    {
        _radius = 1.0; 
    }
    public Circle(double radius)
    {
        SetRadius(radius);
    }

    public double GetArea()
    {
        return _radius * _radius * 3.14159;
    }

     public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            _radius = 1.0;
            Console.WriteLine("Error, radius must be >= 0");
        }
        else
        {
            _radius = radius;
        }
    }
}