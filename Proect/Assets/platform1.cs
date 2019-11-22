using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform1 : MonoBehaviour
{

    public bool Changed;
    public float Timer;



    // Use this for initialization
    void Start ()
    {
        Changed = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Timer += Time.deltaTime;

        if (Changed == true)
        {
            if (Timer <= 3)
                gameObject.transform.position += Vector3.right * Time.deltaTime * 2;
            else
            {
                Changed = false;
                Timer = 0;
            }
        }
        else
        {
            if (Timer <= 3)
                gameObject.transform.position += Vector3.left * Time.deltaTime * 2;
            else
            {
                Changed = true;
                Timer = 0;
            }
        }
    }
}
