public class Structure
{
    public int _structureNumber { get; set; }

    private int width = 1;
    private int height = 1;
    private int large = 1;

    public float _coordX { get; set; }
    public float _coordY { get; set; }
    public float _coordZ { get; set; }


    public int Width
    {
        get
        {
            return width;
        }

        set
        {
            width = value;
        }
    }

    public int Height
    {
        get
        {
            return height;
        }

        set
        {
            height = value;
        }
    }

    public int Large
    {
        get
        {
            return large;
        }

        set
        {
            large = value;
        }
    }
}