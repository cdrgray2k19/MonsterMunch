using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 3f;
    public GameObject playerModel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PauseGame.paused == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
                playerModel.transform.localRotation = Quaternion.Euler(0, 270, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
                playerModel.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
                playerModel.transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
                playerModel.transform.localRotation = Quaternion.Euler(0, 90, 0);
            }
            if (Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.W))
            {
                playerModel.transform.localRotation = Quaternion.Euler(0, 45, 0);
            }
            if (Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.S))
            {
                playerModel.transform.localRotation = Quaternion.Euler(0, 135, 0);
            }
            if (Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.W))
            {
                playerModel.transform.localRotation = Quaternion.Euler(0, 315, 0);
            }
            if (Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.S))
            {
                playerModel.transform.localRotation = Quaternion.Euler(0, 225, 0);
            }
        }
    }
}
