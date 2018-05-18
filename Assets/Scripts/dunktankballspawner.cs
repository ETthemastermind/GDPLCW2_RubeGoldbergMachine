using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dunktankballspawner : MonoBehaviour {

    [SerializeField] private GameObject BallPrefab;
    private GameObject Ball;
    private float ballNumber = 500f;
    private bool createBalls = false;
    private int RandomColor;
    private Color ChosenColor;


    private void OnTriggerEnter(Collider other)
    {
        createBalls = true;
        Debug.Log("test");







    }
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame

    private void Update()
    {

        if (createBalls == true)
        {
            if (ballNumber != 0)
            {
                

                Ball = Instantiate(BallPrefab, transform.position, transform.rotation);
                ballNumber = ballNumber - 1;

                

                
            }
        }
        
        
    }

}
