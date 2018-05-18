using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnHit : MonoBehaviour {

    private bool collided = false;
    private AudioSource source;
    [SerializeField] private AudioClip HitSound;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter()
    {
        if (collided == false)
        {
            Debug.Log("Play Sounds");
            source.PlayOneShot(HitSound, 1f);
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
