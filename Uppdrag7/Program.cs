using System;

namespace Uppdrag7
{
    class Program
    {
        static void Main(string[] args)
        {
            Tekning cirkel = new Cirkel();
            Tekning rektangel = new Rektangel();
            Tekning fyrkant = new Fyrkant();


            cirkel.Draw();
            Console.WriteLine();
            rektangel.Draw();
            Console.WriteLine();
            fyrkant.Draw();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
