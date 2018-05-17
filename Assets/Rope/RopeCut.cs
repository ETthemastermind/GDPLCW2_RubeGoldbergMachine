using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeCut : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "knife")
        {
            Debug.Log("slicey boy");
            rb.isKinematic = false;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
