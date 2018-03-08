public class Rectangle
{
    private double length = 1.0;
    private double width = 1.0;

    public double Length
    {
        get
        {
            return length;
        }
        set
        {
            if (value < 0.0 || value >= 20.0)
                length = 0;
            else
                length = value;
        }
    }
    
    public double Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0.0 || value >= 20.0)
                width = 0;
            else
                width = value;
        }
    }  
    
    public double Perimeter
    {
        get
        {
            return Length * 4;
        }
    }

    public double Area
    {
        get
        {
            return Length * Width;
        }
    }
}//end class
