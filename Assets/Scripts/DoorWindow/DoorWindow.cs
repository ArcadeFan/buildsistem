public class DoorWindow
{
    private int width = 1;
    private int height = 1;
    private int large = 1;
    private int rotation = 0;

    public int _itemId { get; set; }
    public int _itemType { get; set; }
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
    public int Rotation
    {
        get
        {
            return rotation;
        }

        set
        {
            rotation = value;
        }
    }
}
