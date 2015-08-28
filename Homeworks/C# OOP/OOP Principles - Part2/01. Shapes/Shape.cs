public abstract class Shape
{
    private double width;
    private double height;

    public Shape(double height, double width)
    {
        this.Height = width;
        this.Width = width;
    }

    public double Width { get; set; }
    public double Height { get; set; }
    public abstract double CalculateSurface();
}