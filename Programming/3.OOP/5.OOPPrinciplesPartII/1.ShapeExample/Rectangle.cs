namespace _1.ShapeExample
{
    using System;

    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
            : base(height, width)
        { }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        } 
    }
}
