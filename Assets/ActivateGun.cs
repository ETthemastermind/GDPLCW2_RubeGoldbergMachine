using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGun : MonoBehaviour {

    public bool Activate = false;
    public bool Fire = false;
    private float time = 420f;

    [SerializeField] private GameObject bulletPrefab;
    private GameObject bullet;
    private bool BulletFired = false;
    public float speed;

    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DominoBall")
        {
            Activate = true;
        }

        if (other.gameObject.tag == "Bullet")
        {
            Destroy(bullet);
            BulletFired = false;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Activate == true)
        {
            time = time - 1;
            if (time <= 0)
            {
                Fire = true;
            }
            if (BulletFired == false && Fire == true)
            {
                bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                bullet.GetComponent<Rigidbody>().AddForce(Vector3.left * speed);
                BulletFired = true;
            }
        }
        




    }
}
