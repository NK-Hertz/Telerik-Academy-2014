namespace _1.ShapeExample
{
    using System;

    public class Circle : Shape
    {
        public Circle(double radius)
            : base(radius)
        { }

        public override double CalculateSurface()
        {
            return Math.PI * this.Width * this.Width;
        }
    }
}
