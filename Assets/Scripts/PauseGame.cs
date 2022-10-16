using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (!paused)
            {
                Time.timeScale = 0;
                paused = true;
                Cursor.visible = true;
                this.GetComponent<AudioSource>().Pause();
                pauseMenu.SetActive(true);
            }
        }
    }
    
    public void Resume()
    {
        pauseMenu.SetActive(false);
        this.GetComponent<AudioSource>().UnPause();
        Cursor.visible = false;
        paused = false;
        Time.timeScale = 1;
    }
    public void RestartLevel()
    {
        paused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void QuitToMenu()
    {
        paused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
