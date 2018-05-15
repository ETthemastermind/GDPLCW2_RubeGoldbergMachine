using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlingBall : MonoBehaviour {
    public int fling;
    public Rigidbody rb;


    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();

    }

    
    // Update is called once per frame
    void Update ()
    {
        GameObject bucket = GameObject.Find("Bucket 1");
        BallInBucket ballInBucket = bucket.GetComponent<BallInBucket>();
        fling = ballInBucket.flingTheBall;

        if (fling == 1)
        {
            rb.isKinematic = false;


        }        
    }
    
}
