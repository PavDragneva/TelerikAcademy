public struct Point3D
{
    private static readonly Point3D pointO = new Point3D(0, 0, 0);
    public Point3D(int x, int y, int z)
        : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public int X { get; private set; }
    public int Y { get; private set; }
    public int Z { get; private set; }
    public static Point3D PointO
    {
        get { return pointO; }
    }

    public override string ToString()
    {
        return "{ " + this.X + ", " + this.Y + ", " + this.Z + " }";
    }
}