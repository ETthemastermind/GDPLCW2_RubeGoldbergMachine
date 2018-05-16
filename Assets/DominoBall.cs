using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoBall : MonoBehaviour {

    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Domino")
        {
            //Debug.Log("true");
            rb.isKinematic = false;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
