using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{

    private Vector3 mOffset;

    private float mZCoord;

    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseWorlsPos();

    }


    private Vector3 GetMouseWorlsPos()
    {

        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToViewportPoint(mousePoint);

    }





    private void OnMouseDrag()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = GetMouseWorlsPos() + mOffset;
        }

    }



}
