using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class save_struc : MonoBehaviour
{

    [SerializeField] private Transform _structures;

    string path = "Assets/Resources/test.json";
    string pathM = "Assets/Resources/testm.json";

    private List<cubo> struc = new List<cubo>();
    private List<mueble> strucM = new List<mueble>();




    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<Button>().onClick.AddListener(SaveStructureData);
    }

    private void SaveStructureData()
    {


        foreach(var pared in _structures.GetComponentsInChildren<sctruc>())
        {

            struc.Add(pared.getData());


        }
        foreach (var mueble in _structures.GetComponentsInChildren<sctruc>())
        {

            strucM.Add(mueble.getDataM());
        }


        var json = JsonConvert.SerializeObject(struc);
        var sr = File.CreateText(path);       
        sr.Write(json);
        sr.Close();

        var jsonm = JsonConvert.SerializeObject(strucM);
        var srm = File.CreateText(pathM);
        srm.Write(jsonm);
        srm.Close();



    }
}
