using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour {

    [SerializeField] private AudioClip HitSound;
    private AudioSource source;
    [SerializeField] private LoadMachine loadMachine;
    [SerializeField] private SettingsPopup settingsPopup;

	// Use this for initialization
	void Start ()
    {
        settingsPopup.Close();
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    public void Begin()
    {
        source.PlayOneShot(HitSound, 1f);
        SceneManager.UnloadSceneAsync("MainMenu Scene");
        SceneManager.LoadScene("RGM", LoadSceneMode.Single);
    }

    public void returnToMenu()
    {
        settingsPopup.Close();
        SceneManager.UnloadSceneAsync("RGM");
        SceneManager.LoadScene("MainMenu Scene", LoadSceneMode.Single);
    }

    public void PauseMenuOpen()
    {
        settingsPopup.Open();
        Time.timeScale = 0;
    }

    public void RestartMachine()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void QuitMachine()
    {
        Application.Quit();
    }
}
