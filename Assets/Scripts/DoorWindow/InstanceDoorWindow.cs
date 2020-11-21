using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InstanceDoorWindow : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown _type;
    [SerializeField] private TMP_InputField _height;
    [SerializeField] private TMP_InputField _width;
    [SerializeField] private Button _createButton;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _world;

    void Start()
    {
        _createButton.onClick.AddListener(InstanceStructureGO);
    }

    private void InstanceStructureGO()
    {
        var doorWindow = new DoorWindow();

        if (!string.IsNullOrEmpty(_width.text))
            doorWindow.Width = int.Parse(_width.text);
        if (!string.IsNullOrEmpty(_height.text))
            doorWindow.Height = int.Parse(_height.text);

        doorWindow._itemType = _type.value;

        var wall = Instantiate(_prefab, _world);
        wall.GetComponent<DoorWindowProperties>().SetData(doorWindow);
    }
}
