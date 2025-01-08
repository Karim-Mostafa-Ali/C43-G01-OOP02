using System.Drawing;

namespace C43_G01_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 01
            //Person[] people =
            // {
            //new Person ( "Karim", 30 ),
            //new Person ( "Ali", 25 ),
            //new Person ( "Amr", 20 )
            // };

            //Console.WriteLine("Details of Persons:");
            //foreach (var person in people)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //}

            #endregion

            #region Problem 02
            //Console.WriteLine("Enter coordinates of the first point (X Y):");
            //var input1 = Console.ReadLine().Split(' ');
            //Point p1 = new Point(double.Parse(input1[0]), double.Parse(input1[1]));

            //Console.WriteLine("Enter coordinates of the second point (X Y):");
            //var input2 = Console.ReadLine().Split(' ');
            //Point p2 = new Point(double.Parse(input2[0]), double.Parse(input2[1]));

            //static double CalculateDistance(Point p1, Point p2)
            //{
            //    return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            //}

            //Console.WriteLine($"Distance between points p1 and p2: {CalculateDistance(p1, p2):F2}");
            #endregion

            #region Problem 03
            //Person[] people = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1} (Name Age):");
            //    var input = Console.ReadLine().Split(' ');
            //    people[i] = new Person { Name = input[0], Age = int.Parse(input[1]) };
            //}

            //Person oldest = people[0];
            //foreach (var person in people)
            //{
            //    if (person.Age > oldest.Age)
            //    {
            //        oldest = person;
            //    }
            //}

            //Console.WriteLine($"The oldest person is {oldest.Name}, Age: {oldest.Age}");
            #endregion

            #region Problem 04
            //// Create an instance of Rectangle
            //Rectangle rect = new Rectangle();

            //// Set values using properties
            //rect.Width = 10;
            //rect.Height = 5;

            //// Display the rectangle's dimensions and area
            //rect.DisplayInfo();

            //// Attempt to set a negative value
            //rect.Width = -3; // Should print an error message

           

            #endregion
        }
    }
}
