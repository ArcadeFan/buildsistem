using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{



    public Camera camera;
    Vector3 pos = new Vector3(200, 200, 0);

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow);
        if (Input.GetMouseButtonDown(0))
        {

           
            
        }
       

    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)){

            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            gameObject.transform.position = ray.direction.normalized;




        }
    }



}
