using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour

{
    public Transform Ball1;
    public Transform Ball2;
    public Transform WreckingBall;
    public Transform Dominos;
    public Transform Dominos2;
    public Transform Dominos3;
    public Transform Dominos4;
    public Transform Dominos5;
    public Transform Dominos6;
    public Transform Dominos7;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private int CameraToChange = 0;
    

    
      private void FixedUpdate()
    {
        //Debug.Log(CameraToChange);

        GameObject CameraChange = GameObject.Find("Ball1");
        CamChange changeCam = CameraChange.GetComponent<CamChange>();
        CameraToChange = CamChange.ChangeCam;
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

        if (CameraToChange == 2)
        {
            Vector3 desiredPosition = WreckingBall.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }

        if(CameraToChange == 3)
        {
            Vector3 desiredPosition = Dominos.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            transform.LookAt(Dominos);

        }

        if (CameraToChange == 4)
        {
            Vector3 desiredPosition = Dominos2.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            transform.LookAt(Dominos2);

        }

        if (CameraToChange == 5)
        {
            Vector3 desiredPosition = Dominos3.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            transform.LookAt(Dominos3);
        }

        if (CameraToChange == 6)
        {
            Vector3 desiredPosition = Dominos4.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            transform.LookAt(Dominos4);
        }

        if (CameraToChange == 7)
        {
            Vector3 desiredPosition = Dominos5.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            transform.LookAt(Dominos5);
        }

        













    }

}
