using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Button _addStructureButton;
    [SerializeField] private GameObject _addDoorWindowButtons;
    [SerializeField] private Button _addFurniture;

    private void Start()
    {
        _addStructureButton.onClick.AddListener(onAddSctructureButtonClick);
        //_addDoorWindow.onClick.AddListener();
        //_addFurniture.onClick.AddListener();
    }

    private void onAddSctructureButtonClick()
    {
        _addStructureButton.gameObject.SetActive(false);
        _addDoorWindowButtons.SetActive(true);
        //_addFurniture.gameObject.SetActive(true);
    }
}
