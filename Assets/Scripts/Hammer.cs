using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{

    public float Hammer1speed = 200f;
    public float Hammer2speed = 200f;
    public Vector3 rotateCenterOffset;
    public Vector3 rotateAxis;
    private Vector3 originalPos;
    private Vector3 rotateCenter;
    private bool HammerActivate = false;
    private bool HammerSpinUnit = false;

    
    



    // Use this for initialization
	void Start ()
    {
        originalPos = transform.position;
	}

    // Update is called once per frame

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "Hammer")
        {
            Debug.Log("in the muller zone");
            HammerActivate = true;
        }
        
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.name == "C11)SpinnyHammerThing")
        {
            
            HammerSpinUnit = true;
        }

        if (collision.gameObject.tag == "Ball")
        {
            Hammer1speed = 0f;
        }
        if (collision.gameObject.tag == "knife")
        {
            Hammer2speed = 0f;
        }
    }
    void Update ()
    {
        
        if (HammerActivate == true)
        {
            //Debug.Log("It's Clobberin' Time!");
            Vector3 rotateCenter = originalPos + rotateCenterOffset;

            gameObject.transform.RotateAround(rotateCenter, rotateAxis, Hammer1speed * Time.deltaTime);
        }

        if (HammerSpinUnit == true)
        {
            //Debug.Log("It's Clobberin' Time!");
            Vector3 rotateCenter = originalPos + rotateCenterOffset;

            gameObject.transform.RotateAround(rotateCenter, rotateAxis, Hammer2speed * Time.deltaTime);
        }




    }
}
