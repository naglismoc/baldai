using System;

namespace baldai
{
    class Program
    {
        static void Main(string[] args)
        {
            Furniture stalas = new Furniture();

            Leg leg = new Leg();
            leg.Color = "red";
            leg.Material = "wood";
            stalas.legs.Add(leg);
            stalas.legs.Add(leg);
            stalas.legs.Add(leg);
            stalas.legs.Add(leg);

            Console.WriteLine(stalas.printLegs() );

        }
    }
}
