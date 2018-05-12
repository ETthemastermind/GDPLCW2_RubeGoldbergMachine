using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInBucket : MonoBehaviour {

    public Rigidbody rb;
    public int flingTheBall = 0;

    // Use this for initialization
    void Start() {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            rb.isKinematic = false;
            flingTheBall = 1;
        }



            
    }

    void Update()
    {
        
	

   
    }
}
