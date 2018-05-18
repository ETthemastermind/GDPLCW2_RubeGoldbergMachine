using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour {

    [SerializeField] private Text scoreLabel;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = Time.timeSinceLevelLoad.ToString();
    }

        
	

    public void OnOpenSettings()
    {
        Debug.Log("open settings");
    }
}
