using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollide : MonoBehaviour
{
    public GameObject deathText;
    public GameObject fadeOut;
    public GameObject player;
    public AudioSource deathFX;
    public GameObject global;
    public bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && GlobalPlaying.playerPlaying == true)
        {
            GlobalPlaying.playerPlaying = false;
            deathText.SetActive(true);
            fadeOut.SetActive(true);
            player.GetComponent<PlayerControls>().enabled = false;
            if (!isDead)
            {
                global.GetComponent<AudioSource>().Stop();
                deathFX.Play();
                isDead = true;
            }
            StartCoroutine(RespawningLevel());
        }
    }
    IEnumerator RespawningLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
