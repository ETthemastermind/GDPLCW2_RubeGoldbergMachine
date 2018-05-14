using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{

    public float speed = 200f;
    public Vector3 rotateCenterOffset;
    public Vector3 rotateAxis;
    private Vector3 originalPos;

    
    
    // Use this for initialization
	void Start ()
    {
        originalPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {

        Vector3 rotateCenter = originalPos + rotateCenterOffset;

        transform.RotateAround(rotateCenter, rotateAxis, 1.0f);
	}
}
