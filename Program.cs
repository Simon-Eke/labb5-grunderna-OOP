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
            circle1.GetCircleArea();

            // Calls the setter and sets radius to 6
            // Calculates and prints area
            circle1.Radius = 6;
            circle1.GetCircleArea();

            // Another object is created with radius 7
            // Calculates and prints area
            Circle circle2 = new Circle(7);
            circle2.GetCircleArea();

            Console.WriteLine("--------------Spheres!!---------------\n");

            // Object from the Sphere Class is created
            // Displays the area of a circle with radii 3
            Sphere sphere1 = new Sphere(3);
            sphere1.GetVolume();
            sphere1.GetCircleArea();

            

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
