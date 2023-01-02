public class Math {
    public static void Main()
    {
        recurse(1, 1, 5, 5, new Point(1, 1));
    }

    public static void recurse(int bx, int by, int ex, int ey, Point slope)
    {
        Console.WriteLine($"point: {bx}");
        Console.WriteLine($"x: {slope.x + bx}");
        Console.WriteLine($"y: {slope.y + by} \n");

        if(bx >= ex || by >= ey)
        {
            return;
        }
         else
        {
            recurse(bx + slope.x, by + slope.y, ex, ey, slope);
        }
    }
}

