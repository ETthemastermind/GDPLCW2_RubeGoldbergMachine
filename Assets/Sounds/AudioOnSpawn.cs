using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnSpawn : MonoBehaviour {
    public AudioSource source;
    [SerializeField] private AudioClip HitSound;
    [SerializeField] private AudioClip HitSound2;


    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    // Use this for initialization
    void Start ()
    {
        source.PlayOneShot(HitSound, 1f);
       
    }

    

	
	// Update is called once per frame
	void Update () {
		
	}
}
