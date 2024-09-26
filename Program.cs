namespace labb5_grunderna_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Circles!!----------------\n");

            // One object is created with radius 5
            // Calculates and prints area
            Circle circle1 = new Circle(5);
            circle1.GetArea();

            // Sets the radius for areaOfCircle1 to 6
            // Calculates and prints area by calling a method.
            circle1.radius = 6;
            circle1.GetArea();

            // Another object is created with radius 7
            // Calculates and prints area
            Circle circle2 = new Circle(7);
            circle2.GetArea();

            Console.WriteLine("--------------Triangles!!--------------\n");

            // An object of the triangle class is created with b: 2, h: 2, d: 5
            // Displays Area, prism volume, pyramid volume
            Triangle triangle1 = new Triangle(2, 2, 5);
            triangle1.GetArea();
            triangle1.Get_TriangularPrism_Volume();
            triangle1.Get_TriangularPyramid_Volume();

        }
    }
}
