using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb5_grunderna_OOP
{
    class Circle
    {
        
        // private fields declared, radius and pi.
        private int _radius;
        private double pi = Math.PI;

        // Constructor for an object if created in Main()
        public Circle(int inputRadius)
        {
            this._radius = inputRadius;
        }

        // Getter and Setter of _radius
        public int radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        // Method - Calculates and prints area based of _radius
        public void GetArea()
        {
            // Calculates the area r^2*pi
            double areaOfCircle = (_radius ^ 2) * pi;

            // Prints a string where {0} is the radius and {1:###.###} is the area with 3 decimal places
            Console.WriteLine("The area of the circle with radii {0} is {1:###.###} \n({1})\n" , _radius, areaOfCircle);
        }
    }
}
