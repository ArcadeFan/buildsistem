using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{
    Vector3 newPosition;

    public Vector3 sizeD;

    public bool itsPlaceIt;
    
    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.position;
        transform.localScale = sizeD;



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            itsPlaceIt = !itsPlaceIt;


        }

        RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (!itsPlaceIt)
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == transform.name)
                {
                    print("My object is clicked by mouse");

                    newPosition = new Vector3(hit.point.x, 0.5f, hit.point.z);
                    

                    //transform.position = newPosition;

                }

            }
        }
    }


    private void OnCollisionEnter(Collision collision)
    {


        itsPlaceIt = !itsPlaceIt;


    }


}
