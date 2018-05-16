using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dunktankballspawner : MonoBehaviour {

    [SerializeField] private GameObject BallPrefab;
    private GameObject Ball;
    private float ballNumber = 500f;
    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ballNumber != 0)
        {
            Ball = Instantiate(BallPrefab, transform.position, transform.rotation);
            ballNumber = ballNumber - 1;
        }
        
        
    }
}
