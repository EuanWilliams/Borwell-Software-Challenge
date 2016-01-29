using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the length, width and height of the room (in metres): "); //getting measurements
            string dimensions = Console.ReadLine();
            char[] delimiterChars = { ' ', ' ', }; //setting delimiter chars for splitting "dimensions"
            string[] dimensions_array = dimensions.Split(delimiterChars); //splitting dimensions using delimiter chars
            int width_int = Convert.ToInt32(dimensions_array[0]), height_int = Convert.ToInt32(dimensions_array[1]), length_int = Convert.ToInt32(dimensions_array[2]); // coverting strings to integers
            int area_of_floor = width_int * length_int; //working out area of floor using width * length
            float volume_of_room = width_int * length_int * height_int; //working out volume of room with width * length * height
            float volume_of_paint = (((width_int * height_int) * 2) + ((length_int * height_int) * 2)) / 10; //working out in litres how much paint is needed using area of walls / 10
            Console.WriteLine("The area of the floor is: " + area_of_floor); //outputting values
            Console.WriteLine("The volume of paint for the walls: " + volume_of_paint +" litres"); //outputting values
            Console.WriteLine("The volume of the room is: " + volume_of_room + "m^3"); //outputting values
            Console.Write("Press any key to continue... "); //ending program 
            Console.ReadLine();
        }
    }
}
