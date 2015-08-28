using System;
public class Square:Shape
{
    public Square(double height, double width)
        :base(height = width, width)
    {
      
    }

    public override double CalculateSurface()
    {
        return Width * Height;
    }
}