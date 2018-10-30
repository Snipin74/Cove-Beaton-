using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public string mainMenuLevel;
    public GameObject pauseMenu;
    public AudioSource background;

    public void PauseGame()
    {
        Time.timeScale = 0f;
        AudioListener.pause = true;
        pauseMenu.SetActive(true);
        AudioListener.pause = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        pauseMenu.SetActive(false);
        AudioListener.pause = false;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuLevel);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
