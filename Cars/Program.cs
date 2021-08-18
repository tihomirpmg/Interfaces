using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);
            
            ICar seat2 = new Seat("Cordoba", "Dark Grey");
            ICar tesla2 = new Tesla("Model X", "White", 5);
            
            Console.WriteLine(seat.ToString());

            Console.WriteLine("==========================");

            Console.WriteLine(tesla.ToString());

            Console.WriteLine("==========================");

            Console.WriteLine(seat2.ToString());

            Console.WriteLine("==========================");

            Console.WriteLine(tesla2.ToString());

            Console.WriteLine("==========================");
        }
    }
}
