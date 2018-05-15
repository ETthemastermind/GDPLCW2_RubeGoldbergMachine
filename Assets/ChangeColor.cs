using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();	
	}

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Sphere" || collision.gameObject.tag == "Domino")
        {
            rb.isKinematic = false;

            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("_Color");
            rend.material.SetColor("_Color", Color.black);

            rend.material.shader = Shader.Find("Specular");
            rend.material.SetColor("_SpecColor", Color.black);

        }
       
    }

    // Update is called once per frame
    void Update () {
		
	}
}
