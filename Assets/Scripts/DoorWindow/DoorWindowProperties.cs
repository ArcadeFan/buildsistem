using UnityEngine;

public class DoorWindowProperties : MonoBehaviour
{
    private DoorWindow _properties;

    public void SetData(DoorWindow data)
    {
        _properties = data;

        transform.localScale = new Vector3(_properties.Width, _properties.Height, _properties.Large);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
    }

    public void RemakeData(DoorWindow data)
    {
        _properties = data;

        transform.localScale = new Vector3(_properties.Width, _properties.Height, _properties.Large);
        transform.localPosition = new Vector3(_properties._coordX, _properties._coordY, _properties._coordZ);
    }

    public DoorWindow GetData()
    {
        _properties._coordX = transform.position.x;
        _properties._coordY = transform.position.y;
        _properties._coordZ = transform.position.z;

        return _properties;
    }
}
