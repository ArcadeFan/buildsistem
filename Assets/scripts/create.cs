using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class create : MonoBehaviour
{

    
    public GameObject floor;
    public GameObject emptyObj;
    public GameObject forniture;


    public Text imputFieldX;
    public Text imputFieldY;

    public Vector3 dimensions;








    public int xsize;
    public int ysize;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        



    }


    public void Create_forniture()
    {



        GameObject forniture1 = Instantiate(forniture,transform.position, transform.rotation);
        //forniture1.transform.localScale = new Vector3(int.Parse(imputFieldX.text), int.Parse(imputFieldY.text), int.Parse(imputFieldZ.text));

    }

    public void Create_room()
    {

        GameObject emptyOb = Instantiate(emptyObj);

        for (float x = 0; x < int.Parse(imputFieldX.text); x++)
        {
            for (float z = 0; z < int.Parse(imputFieldY.text); z++)
            {



                GameObject go = Instantiate(floor, new Vector3(x * 1, 0, z * 1), Quaternion.identity);
                go.transform.parent = emptyOb.transform;






            }





        }
    }


 
}
