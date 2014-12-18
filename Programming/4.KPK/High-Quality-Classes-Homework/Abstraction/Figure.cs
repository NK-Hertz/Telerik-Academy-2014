using System;

namespace Abstraction
{
    public abstract class Figure
    {
        private double width;
        private double height;
        private double radius;

        public double Width
        {
            get { return this.width; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException
                        ("Width can not be negative or equal to zero!");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height 
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException
                        ("Height can not be negative or equal to zero!");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public double Radius {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException
                        ("Radius can not be negative or equal to zero!");
                }
                else
                {
                    this.radius = value;
                }
            }
        }

        protected Figure(double radius)
        {
            this.Radius = radius;
        }

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
        
    }
}
