using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour {

    private int CameraToChange = 0;
    public int ChangeToCamera2 = 0;
    private int ActiveCamera = 1;
   

	// Use this for initialization
	void Start ()
    {
         
         



    }
	
	// Update is called once per frame
	void Update ()
    {
        GameObject CameraChange = GameObject.Find("Ball1");
        CamChange changeCam = CameraChange.GetComponent<CamChange>();
        CameraToChange = changeCam.ChangeCam;
        
       

        if (ActiveCamera == 1)
        {

        }
        if (CameraToChange == 1)
        {

            ActiveCamera = ActiveCamera + 1;
            Debug.Log(CameraToChange);
            gameObject.SetActive(false);

            if (ActiveCamera == 2 && gameObject.name == "Camera2")
            {
                Debug.Log("True");
                gameObject.SetActive(true);
            }
            
            

        }
        

    }
}
