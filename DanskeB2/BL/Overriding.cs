using System;
using System.Collections.Generic;


namespace BL
{
    public abstract class Shape
    {
        public abstract void Draw();
        public virtual double CalculateArea()
        {
            return 0d;
        }        
    }

    public class Circle : Shape {
        public double Radius{ get; set; }
        public override void Draw()
        {
            Console.WriteLine($"Circle Drawn with radius: {this.Radius}");
        }

        public override double CalculateArea()
        {
            return 3.142d * Radius * Radius;
        }
    }

    public class Square : Shape {
        public double Side { get; set; }
        public override void Draw()
        {
            Console.WriteLine($"Square drawn with side = {this.Side}");
        }
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
    
}
