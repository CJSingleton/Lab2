using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSingleton_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            Double Length, Width, Height, Area, Perimeter, Volume;  // declaring variables
            string Answer;

            //All parts of the code are written inside a do/while loop so that the program can be run as many timeas as the user chooses.

            do
            {
                Console.WriteLine("Please enter the length of the room in feet (example: 24.5).");
                Length = Double.Parse(Console.ReadLine()); //First user input - all three inputs convert string data to 'Double' data type.
                                                           //Changed 'Convert.ToDouble' to 'Double.Parse' - 7/17/2018
                Console.WriteLine("Please enter the width of the room in feet (example: 12.2).");
                Width = Convert.ToDouble(Console.ReadLine()); //Second user input

                Console.WriteLine("Please enter the height of the room in feet (example: 24.5).");
                Height = Convert.ToDouble(Console.ReadLine()); //Third user input

                //The following formulas are used to calculate the area, perimeter and volume based on the user input.

                Area = Length * Width;
                Perimeter = Length * 2 + Width * 2;
                Volume = Length * Width * Height;

                //The following lines display the results of the calculations based on the user input.

                Console.WriteLine($"Area: {Area}");
                Console.WriteLine($"Perimeter: {Perimeter}");
                Console.WriteLine($"Volume: {Volume}");

                //In this next line, the user is prompted to choose y or n but it only checks for 'y'. If they wish to continue,
                //they can keep selecting 'y' to repeat the loop.

                Console.WriteLine("Would you like to continue? (y/n)");
                Answer = Console.ReadLine();

            } while (Answer == "y");

        }
    }
}
