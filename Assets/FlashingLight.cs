using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingLight : MonoBehaviour {
    public float Delay;
    private float DelayTimer;
    public Light light;


	// Use this for initialization
	void Start ()
    {
        DelayTimer = Delay;
        light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        DelayTimer = DelayTimer - 1;
		if (DelayTimer == 0)
        {
            light.intensity = 0;
            DelayTimer = Delay * 2;
           
        }

        if (DelayTimer == Delay)
        {
            light.intensity = 10;
        }
	}
}
