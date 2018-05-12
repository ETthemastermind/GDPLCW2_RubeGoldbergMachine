using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1DoorOpen : MonoBehaviour {
    public float speed; // public variable to change the speed of the rotation of the door, or in this case, to enable me to change which way the door rotates
    public int OpenAngle; // public variable for the angle for which the door is considered open
    private float CurrentZAngle;
    private int ZAngle;
    private float AngleBuffer;
    
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        name = gameObject.name;
        transform.Rotate(Vector3.forward, speed * Time.deltaTime); // rotates he door every frame
        CurrentZAngle = (gameObject.transform.rotation.eulerAngles.z); //assigns the Z angle to its variable
        int ZAngle = (int)CurrentZAngle;
        //Debug.Log("Current Z angle = " + ZAngle); //prints the value of CurrentZAngle to the console
        
        AngleBuffer = ZAngle + 10;

        //Debug.Log(OpenAngle);
        //Debug.Log(ZAngle);

        if (OpenAngle < ZAngle && ZAngle < AngleBuffer)
            speed = 0f;
                
        


            
                
      

		
	}
}
