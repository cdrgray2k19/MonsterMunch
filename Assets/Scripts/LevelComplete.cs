using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public int importedCoins;
    public GameObject completedText;
    public GameObject fadeOut;
    public GameObject player;
    public AudioSource completeFX;
    public bool isComplete = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        importedCoins = GlobalCoins.coinCount;
        if (importedCoins == 8)
        {
            StartCoroutine(LevelCompleted());
        }
    }

    IEnumerator LevelCompleted()
    {
        GlobalPlaying.playerPlaying = false;
        player.GetComponent<PlayerControls>().enabled = false;
        yield return new WaitForSeconds(0.2f);
        completedText.SetActive(true);
        fadeOut.SetActive(true);
        if (!isComplete)
        {
            this.GetComponent<AudioSource>().Stop();
            completeFX.Play();
            isComplete = true;
        }
        yield return new WaitForSeconds(3);
        GlobalLevel.currentLevel++;
        if (GlobalLevel.currentLevel > PlayerPrefs.GetInt("LoadSceneNum"))
        {
            if (GlobalLevel.currentLevel > GlobalLevel.maxLevel)
            {
                PlayerPrefs.SetInt("LoadSceneNum", 0);
            }
            else
            {
                PlayerPrefs.SetInt("LoadSceneNum", GlobalLevel.currentLevel);
            }
        }
        SceneManager.LoadScene(2);
    }
}
