using System;
using System.Collections.Generic;
using System.Text;

namespace Uppdrag7
{
    public class Rektangel : Tekning
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rektangel(double Length = 5, double Width = 8)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public override double Area()
        {
            double area = Width * Length;
            return area;
        }
        public override void Draw()
        {
            Console.WriteLine($"Arean på Rektangeln är: {Area()}");
        }

    }
}
