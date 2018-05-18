using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour {

    
    [SerializeField] private LoadMachine loadMachine;

	// Use this for initialization
	void Start ()
    {
        //settingsPopup.Close();
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}

    

    public void Begin()
    {
        SceneManager.UnloadSceneAsync("MainMenu Scene");
        SceneManager.LoadScene("RGM", LoadSceneMode.Single);
    }

}
