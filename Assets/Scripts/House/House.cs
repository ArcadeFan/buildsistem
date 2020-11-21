using System.Collections.Generic;

public class House
{
    private List<Structure> _structure;
    private List<DoorWindow> _doorWindow;

    public List<Structure> Structure
    {
        get
        {
            return _structure;
        }

        set
        {
            _structure = value;
        }
    }

    public List<DoorWindow> DoorWindow
    {
        get
        {
            return _doorWindow;
        }

        set
        {
            _doorWindow = value;
        }
    }
}
