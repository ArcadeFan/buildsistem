using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class save : MonoBehaviour
{

   // [SerializeField] private Text _altura;
    [SerializeField] private Text _largo;
    [SerializeField] private Text _ancho;
    [SerializeField] private Button _button;
    [SerializeField] private Button _button_add;
    [SerializeField] private GameObject _prefab_estructure;
    [SerializeField] private GameObject _prefab_mueble;

    [SerializeField] private Transform _world;

    int doorNo=0;



    // Start is called before the first frame update
    void Start()
    {
        //SaveStructureData();
        _button.onClick.AddListener(InstanciarEstructura);
        _button_add.onClick.AddListener(InstanciarMueble);

    }

    private void InstanciarMueble()
    {

        var estructura = new mueble();
        // estructura._altura = int.Parse(_altura.text);
        estructura._largo = int.Parse(_largo.text);
        estructura._ancho = int.Parse(_ancho.text);

        var Mueble = Instantiate(_prefab_mueble, _world);
        Mueble.name = "door" + doorNo;
        doorNo++;


        Mueble.GetComponent<sctruc>().SetMueble(estructura);


    }

    private void InstanciarEstructura()
    {
        var estructura = new cubo();
       // estructura._altura = int.Parse(_altura.text);
        estructura._largo = int.Parse(_largo.text);
        estructura._ancho = int.Parse(_ancho.text);

        var wall = Instantiate(_prefab_estructure, _world);

        wall.GetComponent<sctruc>().SetData(estructura);




        
    }

 


}
