using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
     void OnCollisionEnter(Collision colllision)  
    {
        print("1");

        colllision.transform.parent = transform;
    }

    private void OnCollisionExit(Collision collision)
    {
        print("2");

        collision.transform.parent = null;
    }


}
    

    

