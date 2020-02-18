class Rectangle
{
    static double w, h;

    public static double calculateArea() => w * h;

    static int Main()
    {
        w = 10;
        h = 20;
        double area = calculateArea();
        System.Console.WriteLine("rectangle area = " + area.ToString());
        System.Console.ReadKey();
        return 0;
    }
}