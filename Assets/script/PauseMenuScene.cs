using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScene : MonoBehaviour {

    public static bool IsPaused = false;
    public GameObject pauseMenuUI;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (IsPaused)
            {
                Resume();
                Time.timeScale = 1;
            }
            else
            {
                Pause();
                Time.timeScale = 0;
            }
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        IsPaused = false;
        
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        IsPaused = true;
        
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}

