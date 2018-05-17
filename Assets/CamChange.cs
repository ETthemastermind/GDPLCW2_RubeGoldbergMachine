using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour {
    public static int ChangeCam = 0;
	// Use this for initialization
	void Start ()
    {

        //Debug.Log(ChangeCam);
		
	}
    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.tag == "CameraTrigger")
        {
            ChangeCam = ChangeCam + 1;
            //Debug.Log("Camera change imminent");
            Debug.Log(ChangeCam);

        }
        

    }
    // Update is called once per frame
    void Update ()
    {
		
	}
}
