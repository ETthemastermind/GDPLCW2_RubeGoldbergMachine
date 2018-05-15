using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveDomino : MonoBehaviour {

    public int Active; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Domino")
            Debug.Log("Collided");




    }

    // Use this for initialization
    //void Start () {
	//	
	//}
	
	// Update is called once per frame
	//void Update () {
	//	
	//}

    
}
