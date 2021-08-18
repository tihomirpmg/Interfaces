using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLAB
{
    class Circle : IDrawable
    {
        private int radius;
        public Circle(int radius)
        {
            this.Radius = radius;
        }
        public int Radius
        {
            get { return this.radius; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be positive!");
                }
                this.radius = value;
            }
        }
        public void Draw()
        {
            double inR = this.Radius - 0.4;
            double outR = this.Radius + 0.4;

            for (double i = this.Radius; i >= -this.Radius; --i)
            {
                for (double j = -this.Radius; j < outR; j += 0.5)
                {
                    double value = i * i + j * j;
                    if (value >= inR * inR && value <= outR * outR)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
