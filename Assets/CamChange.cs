using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour {
    public int ChangeCam = 0;
	// Use this for initialization
	void Start () {

       
		
	}
    private void OnTriggerEnter(Collider other)
    {
        ChangeCam = 1;
        
    }
    // Update is called once per frame
    void Update ()
    {
		
	}
}
