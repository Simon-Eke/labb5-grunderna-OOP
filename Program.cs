namespace labb5_grunderna_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // One object is created with radius 5
            // Calculates and prints area
            Circle areaOfCircle1 = new Circle(5);
            areaOfCircle1.GetArea();

            // Sets the radius for areaOfCircle1 to 6
            // Calculates and prints area by calling a method.
            areaOfCircle1.radius = 6;
            areaOfCircle1.GetArea();

            // Another object is created with radius 7
            // Calculates and prints area
            Circle areaOfCircle2 = new Circle(7);
            areaOfCircle2.GetArea();
        }
    }
}
