using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class load_stru : MonoBehaviour
{

    [SerializeField] private Button _button;
    [SerializeField] private GameObject _prefap;
    [SerializeField] private GameObject _prefapM;

    [SerializeField] private Transform _world;



    



    // Start is called before the first frame update
    void Start()
    {
        _button.onClick.AddListener(LoadStruct);
    }

   private void LoadStruct()
    {
        var Fpath = Resources.Load<TextAsset>("test").text;
        //var json = File.ReadAllText(Fpath);
        var estruc = JsonConvert.DeserializeObject<List<cubo>>(Fpath);

        foreach(var wall in estruc)
        {

            var go = Instantiate(_prefap, _world);
            go.GetComponent<sctruc>().SetData(wall);

        }

        var FpathM = Resources.Load<TextAsset>("testm").text;
        //var json = File.ReadAllText(Fpath);
        var estruceme = JsonConvert.DeserializeObject<List<mueble>>(FpathM);

        foreach (var mueble in estruceme)
        {

            var go = Instantiate(_prefapM, _world);
            go.GetComponent<sctruc>().SetMueble(mueble);

        }


    }
}
