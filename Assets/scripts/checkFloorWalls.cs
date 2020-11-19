using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkFloorWalls : MonoBehaviour
{

   
    public GameObject wallObj;

    public bool floorcheck;

    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        if (floorcheck == true)
        {
            Debug.Log("piso");
            //Instantiate(wallObj, new Vector3(2, 0, 0), Quaternion.identity);


        }
        else
        {

            Debug.Log("debo poner muro");
            //Instantiate(wallObj, transform.position, transform.rotation);
            //Instantiate(wallObj,,transform.localRotation);


        }

        Destroy(gameObject);

    }


    void OnCollisionEnter(Collision collision)
    {


        //Debug.Log("chocque" + gameObject.name);


        floorcheck = true;


    }



}
