using Newtonsoft.Json;
using SimpleFileBrowser;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SaveHouse : MonoBehaviour
{
    [SerializeField] private Button _saveButton;
    [SerializeField] private GameObject _structures;

    private House _house = new House();

    private void Start()
    {
        FileBrowser.SetFilters(false, new FileBrowser.Filter("JSON File", ".json"));
        FileBrowser.SetDefaultFilter(".json");

        _saveButton.onClick.AddListener(SaveFile);
    }

    private void SaveFile()
    {
        _house.Structure = new List<Structure>();
        _house.DoorWindow = new List<DoorWindow>();

        foreach (Transform structure in _structures.transform)
        {
            if (structure.GetComponent<StructureProperties>() != null)
                _house.Structure.Add(structure.GetComponent<StructureProperties>().GetData());
            if (structure.GetComponent<DoorWindowProperties>() != null)
                _house.DoorWindow.Add(structure.GetComponent<DoorWindowProperties>().GetData());
        }

        FileBrowser.ShowSaveDialog(onSuccessSave, null, false, false, "C:\\", "Guardar casa", "Guardar");
    }

    private void onSuccessSave(string[] paths)
    {
        var json = JsonConvert.SerializeObject(_house);
        var savedFile = File.CreateText(paths[0]);
        savedFile.Write(json);
        savedFile.Close();
    }
}
