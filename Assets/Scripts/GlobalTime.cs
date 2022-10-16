using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTime : MonoBehaviour
{
    public GameObject textTime;
    public int seconds = 30;
    public bool deductingTime = false;
    public GameObject timeUpText;
    public GameObject fadeOut;
    public GameObject player;
    public AudioSource timeUpFX;
    public bool isEnd = false;

    // Update is called once per frame
    void Update()
    {
        if (seconds == 0 && GlobalPlaying.playerPlaying == true)
        {
            GlobalPlaying.playerPlaying = false;
            timeUpText.SetActive(true);
            fadeOut.SetActive(true);
            player.GetComponent<PlayerControls>().enabled = false;
            if (!isEnd)
            {
                this.GetComponent<AudioSource>().Stop();
                timeUpFX.Play();
                isEnd = true;
            }
            StartCoroutine(RespawningLevel());
        }
        else
        {
            if (deductingTime == false)
            {
                deductingTime = true;
                StartCoroutine(deductSecond());
            }
        }
    }
    IEnumerator deductSecond()
    {
        yield return new WaitForSeconds(1);
        seconds--;
        textTime.GetComponent<Text>().text = "TIME: " + seconds;
        if (seconds <= 15)
        {
            textTime.GetComponent<Text>().color = new Color(1, 0.5f, 0);
        }
        if (seconds <= 5)
        {
            textTime.GetComponent<Text>().color = new Color(1, 0, 0);
        }

        deductingTime = false;
    }

    IEnumerator RespawningLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }
}
