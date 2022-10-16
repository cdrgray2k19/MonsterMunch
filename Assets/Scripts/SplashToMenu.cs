using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadMenu());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator loadMenu()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(1);
    }
}
