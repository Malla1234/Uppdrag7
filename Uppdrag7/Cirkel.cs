using System;
using System.Collections.Generic;
using System.Text;

namespace Uppdrag7
{
   public class Cirkel : Tekning
    {
       public double Radius { get; set; }

        // Constructor
        public Cirkel(double Radius = 8)
        {
            this.Radius = Radius;
        }
        // method
        public override double Area()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2));
        }
        public override void Draw()
        {
            Console.WriteLine($"Arean på Cirkeln är: {Area()}"); 
        }
    }
}
