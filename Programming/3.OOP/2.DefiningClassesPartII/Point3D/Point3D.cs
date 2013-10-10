using System;
using System.Text;

public struct Point3D
{
    public static readonly Point3D Start = new Point3D(0, 0, 0);

    public Point3D(int pointX, int pointY, int pointZ)
        : this()
    {
        this.PointX = pointX;
        this.PointY = pointY;
        this.PointZ = pointZ;
    }

    public int PointX 
    {   
        get;
        set;
    }

    public int PointY 
    { 
        get;
        set; 
    }

    public int PointZ 
    {
        get;
        set;
    }

    public override string ToString()
    {
        string resultText = string.Format("Point X: {0}\nPoint Y: {1}\nPoint Z: {2} \n", this.PointX,this.PointY,this.PointZ);
        return resultText.ToString();
    }
}