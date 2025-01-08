using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP02
{
    internal struct Rectangle
    {
        // Private fields
        private double width;
        private double height;

        // Public properties for width
        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Error: Width cannot be negative.");
                }
            }
        }

        // Public properties for height
        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Error: Height cannot be negative.");
                }
            }
        }

        // Read-only property for Area
        public double Area
        {
            get { return width * height; }
        }

        // Method to display rectangle information
        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Area: {Area}");
        }
    }
}
