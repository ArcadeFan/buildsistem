using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    Vector3 newPosition;
    public bool itsPlaceIt;


    public Text imputFieldXF;
    public Text imputFieldYF;
    

    public GameObject hud;


    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.position;
        hud.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetMouseButtonDown(0))
        {
            itsPlaceIt = !itsPlaceIt;


        }

        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");


            transform.rotation = Quaternion.Euler(0, 90, 0) ;

        }





        RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (!itsPlaceIt)
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == transform.name)
                {

                    hud.SetActive(true);

                    newPosition = new Vector3(hit.point.x,transform.localScale.y/2, hit.point.z);


                    transform.position = newPosition;

                }

            }
        }
    }


    private void OnCollisionEnter(Collision collision)
    {


        //itsPlaceIt = !itsPlaceIt;


    }

    public void move_obj()
    {

    }



    public void Modify_Door()
    {

        transform.localScale = new Vector3(int.Parse(imputFieldXF.text), int.Parse(imputFieldYF.text), 1);
        hud.SetActive(false);
    }

    public void cancel_action()
    {

        itsPlaceIt = true;
        hud.SetActive(false);
    }


}
