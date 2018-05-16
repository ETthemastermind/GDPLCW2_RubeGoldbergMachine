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
        if (collision.gameObject.name == "Hammer")
        {
            //Debug.Log("FORRRRRR!");
            gameObject.GetComponent<Rigidbody>().velocity = (Vector3.left * speed);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
