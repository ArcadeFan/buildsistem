using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InstanceStructure : MonoBehaviour
{
    [SerializeField] private TMP_InputField _altura;
    [SerializeField] private TMP_InputField _largo;
    [SerializeField] private TMP_InputField _ancho;
    [SerializeField] private Button _createButton;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _world;

    void Start()
    {
        _createButton.onClick.AddListener(InstanceStructureGO);
    }

    private void InstanceStructureGO()
    {
        var structure = new Structure();

        if (!string.IsNullOrEmpty(_ancho.text))
            structure.Width = int.Parse(_ancho.text);
        if (!string.IsNullOrEmpty(_altura.text))
            structure.Height = int.Parse(_altura.text);
        if (!string.IsNullOrEmpty(_largo.text))
            structure.Large = int.Parse(_largo.text);

        for (int i = 0; i < 5; i++)
        {
            structure._structureNumber = i;

            var wall = Instantiate(_prefab, _world);
            wall.GetComponent<StructureProperties>().SetData(structure);
        }
    }
}
