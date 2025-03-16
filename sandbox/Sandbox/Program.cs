class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Today - March 4, 2025");

        // double x = 10;
        Circle myCircle = new Circle(10);
        myCircle.DisplayCircleArea();
        Cylinder myCylinder = new Cylinder(10, myCircle);
        double volume = myCylinder.GetVolume();
        Console.WriteLine($"The cylinder volume is: {volume}");
        // Circle myCircle2 = new Circle(20);
        // myCircle.DisplayCircleArea();
        
        // for(int i = 0; i < 30 ; i++)
        // {
        //     myCircle.SetRadius(i);
        //     double circleArea = myCircle.GetArea();
        //     Console.WriteLine($"{i}: Circle area is: {circleArea}");

        //     // myCircle.DisplayCircleArea();
        // }
    }

}
