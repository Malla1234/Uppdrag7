using System;
using System.Collections.Generic;
using System.Text;

namespace Uppdrag7
{
    // Parentclass 
   public class Tekning
    {
       // Filds 
       public int Length { get; set; }
       public int Width { get; set; }

        //Method 
        public virtual double Area() 
        {
            return Length * Width;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Arean på ** är:");
        }
        
    }
}
