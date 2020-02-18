class Rectangle
{
    public double Area()
    {
        return Width * Height;
    }

    static int Main()
    {
        double rectArea = Area(10,20);
        System.Console.WriteLine("rectangle area= "+rectArea.ToString());
        System.Console.ReadKey();
        return 0;
    }
}