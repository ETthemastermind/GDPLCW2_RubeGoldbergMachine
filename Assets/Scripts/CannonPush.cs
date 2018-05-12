using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonPush : MonoBehaviour {

    private int loaded = 0;
    private int Timer = 180;
    public float Speed = 50f;
    private bool Shot = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameObject pushplat = GameObject.Find("CannonFloor");
        CannonLoaded PushingPlatform = pushplat.GetComponent<CannonLoaded>();
        loaded = PushingPlatform.Cloaded;


        if (loaded == 1 && Timer != 0)
        {
            Timer = Timer - 1;
            
        }

        if (Timer <= 0 && loaded == 1 & Shot == false)
        {
            transform.position += Vector3.left * Speed * Time.deltaTime;
            Shot = true;
        
        }




        //if (loaded == 1 && Timer != 0)
        //{ 
        //    transform.position += Vector3.left * Speed * Time.deltaTime;
        //    Timer = Timer - 1;
        //
        //    if (Timer <= 0)
        //        Debug.Log("Working");


    }
}
