using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerHit : MonoBehaviour {
    public float speed = 0f;
	// Use this for initialization
	void Start ()
    {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hammer")
        {
            Debug.Log("FORRRRRR!");
            if (gameObject.tag == "Ball")
            {
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * speed);
            }

            if (gameObject.tag == "knife")
            {
                Debug.Log("Hammer Hit Knife");
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * speed);

            }
            
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
