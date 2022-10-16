using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeRotation : MonoBehaviour
{
    public float rotSpeedX;
    public float rotSpeedY;
    public float rotSpeedZ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotSpeedX * Time.timeScale, rotSpeedY * Time.timeScale, rotSpeedZ * Time.timeScale, Space.World);
    }
}
