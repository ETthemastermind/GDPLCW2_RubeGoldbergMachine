using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnHit : MonoBehaviour {

    private bool collided = false;
    private int caseSwitch = 1;
    private bool Ball2Collided1 = false;
    private bool StopScream = false;
    public float volume = 1f;
    private AudioSource source;
    public bool BallFlingException;
    [SerializeField] private AudioClip HitSound;
    [SerializeField] private AudioClip HitSound2;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (collided == false && BallFlingException == true)

        {
            
            switch (caseSwitch)
            {
                case 1:
                    Debug.Log("Ball Fling Exception");
                    source.PlayOneShot(HitSound, volume);
                    caseSwitch = 2;
                    

                    break;

                case 2:
                    if (other.gameObject.tag != "CannonFloor")
                    {
                        Debug.Log("sound 2");
                        Debug.Log("Ball Fling Exception");
                        source.PlayOneShot(HitSound2, volume);

                    }
                    break;

                case 3:

                    break;

                default:
                    Debug.Log("Stop scream error");
                    break;
            }

            if (other.gameObject.name.Contains("Stop"))
            {
                caseSwitch = 3;
            }
        
        

        
            

            

            
            
            
                
        }

        else if (collided == false)
        {
            Debug.Log("Play Sounds");
            source.PlayOneShot(HitSound, volume);
            collided = true;
            StartCoroutine("ExitCol");
        }



    }

    IEnumerator ExitCol()
    {
        yield return new WaitForSeconds(0.5f);
        collided = false;
    }
   
}
