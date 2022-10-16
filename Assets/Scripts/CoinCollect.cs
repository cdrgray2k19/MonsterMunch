using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinCollect : MonoBehaviour
{
    public AudioSource collectFX;
    public GameObject ground;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            collectFX.Play();
            GlobalCoins.coinCount++;
            //spawn in random place on map, get random x and z from ground object, then place on same y
            System.Random rand = new System.Random();
            double xPos = (ground.transform.localPosition.x - ground.transform.localScale.x/2) + ((ground.transform.localScale.x) * (rand.NextDouble()));
            double zPos = (ground.transform.localPosition.z - ground.transform.localScale.z/2) + ((ground.transform.localScale.z) * (rand.NextDouble()));
            transform.position = new Vector3((float)xPos, 0.75f, (float)zPos);
        }
        else if (other.tag == "Spike")
        {
            //not working fully, coins still spawning where you cant collect them because they are too near spikes
            System.Random rand = new System.Random();
            double xPos = (ground.transform.localPosition.x - ground.transform.localScale.x/2) + ((ground.transform.localScale.x) * (rand.NextDouble()));
            double zPos = (ground.transform.localPosition.z - ground.transform.localScale.z/2) + ((ground.transform.localScale.z) * (rand.NextDouble()));
            transform.position = new Vector3((float)xPos, 0.75f, (float)zPos);
        }
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
