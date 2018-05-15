﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour

{
    public Transform Ball1;
    public Transform Ball2;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private int CameraToChange = 0;
    

    
      private void FixedUpdate()
    {


        GameObject CameraChange = GameObject.Find("Ball1");
        CamChange changeCam = CameraChange.GetComponent<CamChange>();
        CameraToChange = changeCam.ChangeCam;
        //Debug.Log(CameraToChange);
        


        if (CameraToChange == 0)
        {
            Vector3 desiredPosition = Ball1.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

        }

        if (CameraToChange == 1)
        {
            Vector3 desiredPosition = Ball2.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }

    
        



        

    }

}
