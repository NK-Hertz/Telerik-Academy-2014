namespace UsingVarExprAndConst
{
    using System;

    public class Size
    {
      private double width, heigth;

      public Size(double width, double heigth)
      {
        this.Width = width;
        this.Heigth = heigth;
      }

        public double Width 
        { 
            get { return this.width; }
            set { this.width = value; }
        }
        public double Heigth 
        { 
            get { return this.heigth; }
            set { this.heigth = value; }
        }

        public static Size RotateSize(Size sizeToRotate, double angle)
        {
            double cosineOfWidth = Math.Abs(Math.Cos(angle)) * sizeToRotate.Width;
            double sineOfWidth = Math.Abs(Math.Sin(angle)) * sizeToRotate.Width;
            
            double cosineOfHeigth = Math.Abs(Math.Cos(angle)) * sizeToRotate.Heigth;
            double sineOfHeigth = Math.Abs(Math.Sin(angle)) * sizeToRotate.Heigth;

            double resultWidth = cosineOfWidth + sineOfHeigth;
            double resultHeigth = cosineOfHeigth + sineOfWidth;

            return new Size(resultWidth, resultHeigth);
        }
    }
}
