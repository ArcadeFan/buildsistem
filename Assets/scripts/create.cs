using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class create : MonoBehaviour
{

    
    public GameObject floor;
    public GameObject wallobj;



    public GameObject emptyObj;


    public GameObject room_create;
    public Text imputFieldX;
    public Text imputFieldY;
    public Text imputFieldZ;


    public Vector3 dimensions;



    public GameObject door_create;
    public int doorNo = 0;
    public GameObject door;
    public Text imputFieldXF;
    public Text imputFieldYF;




    public int xsize;
    public int ysize;


    

    // Start is called before the first frame update
    void Start()
    {

        door_create.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

       
        


    }


    public void Create_forniture()
    {



        GameObject door1 = Instantiate(door,transform.position, transform.rotation);
        door1.transform.localScale = new Vector3(int.Parse(imputFieldXF.text), int.Parse(imputFieldYF.text),1);

        door1.name = "door"+doorNo;

        doorNo++;


    }

    public void Create_room()
    {

        GameObject emptyOb = Instantiate(emptyObj);

        for (int x = 0; x < int.Parse(imputFieldX.text); x++)
        {

            
            for (int z = 0; z < int.Parse(imputFieldY.text); z++)
            {

                //GameObject wa = Instantiate(wallobj, new Vector3(x - 1, 0, 0), Quaternion.identity);
                //GameObject wa2 = Instantiate(wallobj, new Vector3(-0.5f, 0, z), Quaternion.identity);
                //GameObject wa = Instantiate(wallobj, new Vector3(z, 0, 0), Quaternion.identity);

                


                GameObject go = Instantiate(floor, new Vector3(x * 1, transform.localScale.y / 2, z * 1), Quaternion.identity);

                GameObject wa2 = Instantiate(wallobj, new Vector3(-0.5f, transform.localScale.y / 2, z), Quaternion.identity);
                wa2.transform.localScale = new Vector3(1, int.Parse(imputFieldZ.text), 1);
                GameObject wa3 = Instantiate(wallobj, new Vector3(int.Parse(imputFieldX.text), 0, z), Quaternion.identity);
                wa3.transform.localScale = new Vector3(1, int.Parse(imputFieldZ.text), 1);


                go.transform.parent = emptyOb.transform;

                
                

                wa2.transform.parent = wa3.transform.parent = emptyOb.transform;




            }

            GameObject wa4 = Instantiate(wallobj, new Vector3(x, 0,int.Parse(imputFieldY.text)), Quaternion.identity);
            wa4.transform.localScale = new Vector3(1, int.Parse(imputFieldZ.text), 1);
            GameObject wa = Instantiate(wallobj, new Vector3(x, 0, -0.5f), Quaternion.Euler(0, 90, 0));
            wa.transform.localScale = new Vector3(1, int.Parse(imputFieldZ.text), 1);
            //GameObject wa2 = Instantiate(wallobj, new Vector3(-0.5f, 0, x), Quaternion.identity);
            //GameObject wa3 = Instantiate(wallobj, new Vector3(x, 0, (int.Parse(imputFieldX.text) *1) - 0.5f), Quaternion.Euler(0, 90, 0));
            //GameObject wa4 = Instantiate(wallobj, new Vector3((int.Parse(imputFieldY.text) * 1) - 0.5f, 0,x), Quaternion.Euler(0, 90, 0));



            

            wa.transform.parent = wa4.transform.parent =  emptyOb.transform;






        }

        room_create.SetActive(false);
        door_create.SetActive(true);
    }

    
 
}
