using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
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
            if (Timer <= 2)
                gameObject.transform.position += Vector3.up * Time.deltaTime * 2;
            else
            {
                Changed = false;
                Timer = 0;
            }
        }
        else
        {
            if (Timer <= 2)
                gameObject.transform.position += Vector3.down * Time.deltaTime * 2;
            else
            {
                Changed = true;
                Timer = 0;
            }
        }
    }
}
