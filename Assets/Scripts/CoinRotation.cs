using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinRotation : MonoBehaviour
{
    public int rotSpeed = 2;
    public float bounceSpeed = 0.5f;
    public bool up = true;
    public float startY;
    public GameObject ground;
    void Start()
    {
        /*System.Random rand = new System.Random();
        startY = (float)transform.position.y;
        double xPos = (ground.transform.localPosition.x - ground.transform.localScale.x/2) + ((ground.transform.localScale.x) * (rand.NextDouble()));
        double zPos = (ground.transform.localPosition.z - ground.transform.localScale.z/2) + ((ground.transform.localScale.z) * (rand.NextDouble()));
        transform.position = new Vector3((float)xPos, 0.75f, (float)zPos);*/
    }
    void Update()
    {
        transform.Rotate(0, rotSpeed * Time.timeScale, 0, Space.World);
        if (transform.position.y <= startY)
        {
            up = true;
        }
        if (transform.position.y >= startY+0.5)
        {
            up = false;
        }
        if (up)
        {
            transform.position += Vector3.up * Time.deltaTime * bounceSpeed;
        }
        else
        {
            transform.position += Vector3.down * Time.deltaTime * bounceSpeed;
        }
    }
}
