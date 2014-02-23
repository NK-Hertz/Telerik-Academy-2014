namespace _1.ShapeExample
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        protected Shape(double radius)
        {
            this.height = radius;
            this.width = radius;
        }

        protected Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }


        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public virtual double CalculateSurface()
        {
            return 0;
        }
    }
}
