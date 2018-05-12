using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonLoaded : MonoBehaviour {

    public Rigidbody rb;
    public int Cloaded = 0;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            
            Cloaded = 1;

           
        }




    }
    void Update ()
    {
		
	}
}
