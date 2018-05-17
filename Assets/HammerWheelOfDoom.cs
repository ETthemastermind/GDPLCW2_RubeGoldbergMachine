using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerWheelOfDoom : MonoBehaviour {
    public float speed = 200f;
    public Vector3 rotateCenterOffset;
    public Vector3 rotateAxis;
    private Vector3 originalPos;
    private Vector3 rotateCenter;
    private bool HammerActivate = false;

    // Use this for initialization
    void Start () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Debug.Log("ture");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
