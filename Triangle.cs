using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb5_grunderna_OOP
{
    class Triangle
    {
        // private fields declared.
        private int _base;
        private int _height;
        private int _depth;
        

        // Constructor for an object if created in Main()
        public Triangle(int inputBase, int inputHeight, int inputDepth)
        {
            _base = inputBase;
            _height = inputHeight;
            _depth = inputDepth;
        }

        // 2nd Constructor if only the Base and Height is given.
        public Triangle(int inputBase, int inputHeight)
        {
            _base = inputBase;
            _height = inputHeight;
            _depth = 0;
        }

        // Getter and Setter of Base, depth and height
        public int Base { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }

        // Method to calculate and display the Area.
        public void GetArea()
        {
            double areaOfTriangle = Convert.ToDouble(_base * _height);
            areaOfTriangle /= 2;

            Console.Write("The area (in unit squares) of your 2d triangle with ");
            Console.WriteLine($"base: {_base} and height: {_height} \nis: {areaOfTriangle}\n");
        }

        // Method to calculate and display the Volume.
        public void Get_TriangularPrism_Volume()
        {
            double areaOfTriangle = Convert.ToDouble(_base * _height);
            // area = area / 2
            areaOfTriangle /= 2;

            double volumeOfPrism = areaOfTriangle * _depth;
            // Displays the volume.
            Console.WriteLine($"The volume of your prism is {volumeOfPrism} cubed units\n");
        }

        // Method to calculate and display the Volume.
        public void Get_TriangularPyramid_Volume()
        {
            double areaOfTriangle = Convert.ToDouble(_base * _height);
            areaOfTriangle /= 2;

            // Formula for pyramid volume is Base * Height / 3. Height is "_depth" in my example.
            double volumeOfPyramid = areaOfTriangle * _depth / 3;

            // Displays the volume rounded down to 3 decimal places.
            Console.WriteLine("The volume of your pyramid is {0:###.###} cubed units\n" , volumeOfPyramid);
        }

    }
}