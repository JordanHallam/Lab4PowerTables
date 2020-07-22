using System;

namespace Lab4PowerTables
{
    class Program
    {
        static void Main(string[] args)
        {
            int square = 1;
            int cube = 1;
            string cont = "y";
            while (cont == "y")
            {
                Console.WriteLine("Pick a number, any number ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("Number     Square     Cube");
                Console.WriteLine("==========================");
                int tick = 1;

                for (tick = 1; tick <= input; tick++)
                {
                    square = tick * tick;
                    cube = tick * tick * tick;
                    Console.WriteLine("{0}          {1}         {2}", tick, square, cube);
                }
                Console.WriteLine("Would you like to continue?");
                cont = Console.ReadLine();

            }

        }
    }
}

