using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootRelease : MonoBehaviour {
    public Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Boot Go");
        if (collision.gameObject.tag == "rope")
        {
            rb.isKinematic = false;
        }
    }





    // Update is called once per frame
    void Update () {
		
	}
}
