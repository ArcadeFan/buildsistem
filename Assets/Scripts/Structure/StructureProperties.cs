using UnityEngine;

public class StructureProperties : MonoBehaviour
{
    private Structure _properties;

    public void SetData(Structure data)
    {
        _properties = data;
        _properties._structureNumber = data._structureNumber;

        switch (_properties._structureNumber)
        {
            case 0:
                transform.localScale = new Vector3(_properties.Width, transform.localScale.y, _properties.Large);
                transform.localPosition = new Vector3(_properties.Width / 2, transform.localPosition.y, transform.localPosition.z);
                break;
            case 1:
                transform.localScale = new Vector3(_properties.Width, _properties.Height, transform.localScale.z);
                transform.localPosition = new Vector3(_properties.Width / 2, _properties.Height / 2, (float)(_properties.Large / 2 + 0.5));
                break;
            case 2:
                transform.localScale = new Vector3(transform.localScale.x, _properties.Height, _properties.Large);
                transform.localPosition = new Vector3((float)(_properties.Width - _properties.Large - 0.5), _properties.Height / 2, _properties.Large - _properties.Width);
                break;
            case 3:
                transform.localScale = new Vector3(transform.localScale.x, _properties.Height, _properties.Large);
                transform.localPosition = new Vector3((float)(_properties.Width + 0.5), _properties.Height / 2, transform.localPosition.z);
                break;
            case 4:
                transform.localScale = new Vector3(_properties.Width, _properties.Height, transform.localScale.z);
                transform.localPosition = new Vector3(_properties.Width / 2, _properties.Height / 2, (float)(-_properties.Width / 2 - 0.5));
                break;
            default:
                break;
        }
    }

    public void RemakeData(Structure data)
    {
        _properties = data;

        transform.localScale = new Vector3(_properties.Width, _properties.Height, _properties.Large);
        transform.localPosition = new Vector3(_properties._coordX, _properties._coordY, _properties._coordZ);
    }

    public Structure GetData()
    {
        _properties.Width = (int)transform.localScale.x;
        _properties.Height = (int)transform.localScale.y;
        _properties.Large = (int)transform.localScale.z;
        _properties._coordX = transform.localPosition.x;
        _properties._coordY = transform.localPosition.y;
        _properties._coordZ = transform.localPosition.z;

        return _properties;
    }
}
