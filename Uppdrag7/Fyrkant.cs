using System;
using System.Collections.Generic;
using System.Text;

namespace Uppdrag7
{
    public class Fyrkant : Tekning
    {
        public int Sides { get; set; }
       
        public Fyrkant(int Sides = 15)
        {
            this.Sides = Sides;
        }
        public override double Area()
        {
            int area = Sides * Sides;
            return area;
        }
        public override void Draw()
        {
            Console.WriteLine($"Arean på Fyrkanten är: {Area()}");
        }
    }
}
