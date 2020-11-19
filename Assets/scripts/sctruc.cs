using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sctruc : MonoBehaviour
{
    private cubo _propierties;
    private mueble _prop_mueble;
    public GameObject floor;
    public GameObject wallobj;
    
    
    



    public void SetData(cubo data)
    {

        _propierties = data;


        for (int x = 0; x < _propierties._largo; x++)
        {


            for (int z = 0; z < _propierties._ancho; z++)
            {


                GameObject go = Instantiate(floor, new Vector3(x * 1, transform.localScale.y / 2, z * 1), Quaternion.identity);

                GameObject wa2 = Instantiate(wallobj, new Vector3(-0.5f, transform.localScale.y / 2, z), Quaternion.identity);
                //wa2.transform.localScale = new Vector3(1, int.Parse(imputFieldZ.text), 1);
                GameObject wa3 = Instantiate(wallobj, new Vector3(_propierties._largo, 0, z), Quaternion.identity);
                //wa3.transform.localScale = new Vector3(1, int.Parse(imputFieldZ.text), 1);


                go.transform.parent = transform;




                wa2.transform.parent = wa3.transform.parent = transform;





            }

            GameObject wa4 = Instantiate(wallobj, new Vector3(x, 0, _propierties._ancho), Quaternion.identity);
           // wa4.transform.localScale = new Vector3(1, int.Parse(imputFieldZ.text), 1);
            GameObject wa = Instantiate(wallobj, new Vector3(x, 0, -0.5f), Quaternion.Euler(0, 90, 0));
            //wa.transform.localScale = new Vector3(1, int.Parse(imputFieldZ.text), 1);
         





            wa.transform.parent = wa4.transform.parent = transform;


        }






    }


    public cubo getData()
    {
        //o si?

        if (_propierties != null)
        {
            _propierties._coordX = transform.position.x;
            _propierties._coordY = transform.position.y;
            _propierties._coordZ = transform.position.z;

            return _propierties;
        }else
        {
            return null;
        }
    }

    public mueble getDataM()
    {
        //o si?

        if (_prop_mueble != null)
        {
            _prop_mueble._coordX = transform.position.x;
        _prop_mueble._coordY = transform.position.y;
        _prop_mueble._coordZ = transform.position.z;

        return _prop_mueble;

    }else
        {
            return null;
        }
    }


    public void SetMueble(mueble data)
    {


        _prop_mueble = data;
        
        transform.localScale = new Vector3(_prop_mueble._ancho, _prop_mueble._altura, 1);
        
 

        




    }

}
