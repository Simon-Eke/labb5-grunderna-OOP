using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb5_grunderna_OOP
{
    class Sphere : Circle
    {
        public Sphere(int inputRadius) : base(inputRadius)
        {
            base._radius = inputRadius;
        }

        public void GetVolume()
        {

            double radiusCubed = Math.Pow(_radius, 3);
            // Calculates the volume 4/3 * r^3 * pi
            double volumeOfCircle = 4 * radiusCubed * pi / 3;

            // Prints a string where {0} is the radius and {1:####.###} is the volume with 3 decimal places
            Console.WriteLine("The volume of the circle with radii {0} is {1:####.###} units cubed \n({1})\n", _radius, volumeOfCircle);
        }
    }
}
