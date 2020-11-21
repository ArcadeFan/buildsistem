using Newtonsoft.Json;
using SimpleFileBrowser;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadHouse : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _structurePrefab;
    [SerializeField] private GameObject _doorWindowPrefab;
    [SerializeField] private Transform _world;

    private House house = new House();

    void Start()
    {
        FileBrowser.SetFilters(false, new FileBrowser.Filter("JSON File", ".json"));
        FileBrowser.SetDefaultFilter(".json");

        _button.onClick.AddListener(RemakeHouse);
    }

    private void RemakeHouse()
    {
        FileBrowser.ShowLoadDialog(onSuccessLoad, null, false, false, "C:\\", "Cargar casa", "Abrir");
    }

    private void onSuccessLoad(string[] paths)
    {
        var json = File.ReadAllText(paths[0]);
        house = JsonConvert.DeserializeObject<House>(json);

        Debug.Log(house);

        foreach (var structure in house.Structure)
        {
            var go = Instantiate(_structurePrefab, _world);
            go.GetComponent<StructureProperties>().RemakeData(structure);
        }

        foreach (var doorWindow in house.DoorWindow)
        {
            var go = Instantiate(_doorWindowPrefab, _world);
            go.GetComponent<DoorWindowProperties>().RemakeData(doorWindow);
        }
    }
}
