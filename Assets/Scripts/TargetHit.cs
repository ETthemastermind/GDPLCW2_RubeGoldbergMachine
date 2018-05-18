using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour {

    private Rigidbody rb;

    // Use this for initialization

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DunkPaddleTank")
        {
            Debug.Log("Dunked");
          
            rb.constraints &= ~RigidbodyConstraints.None; 

        }
    }
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
