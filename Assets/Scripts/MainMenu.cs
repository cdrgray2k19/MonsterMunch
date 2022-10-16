using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int loadLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        GlobalLevel.currentLevel = 3;
        SceneManager.LoadScene(2);
    }
    public void Load()
    {
        loadLevel = PlayerPrefs.GetInt("LoadSceneNum");
        if (loadLevel > GlobalLevel.maxLevel){
            PlayerPrefs.SetInt("LoadSceneNum", 0);
            loadLevel = 0;
        }
        if (loadLevel < 3)
        {
            GlobalLevel.currentLevel = 3;
            SceneManager.LoadScene(2);
        }
        else
        {
            GlobalLevel.currentLevel = loadLevel;
            SceneManager.LoadScene(loadLevel);
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}
