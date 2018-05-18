using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    [SerializeField] private GameObject bulletPrefab;
    private GameObject bullet;
    private bool BulletFired = false;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        
    }
    // Update is called once per frame
    void Update ()
    {

        if (Input.GetKeyDown("w"))
            if (BulletFired == false)
            {
                bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                bullet.GetComponent<Rigidbody>().velocity = (Vector3.left * speed);
                //BulletFired = true;
            }






    }
}
