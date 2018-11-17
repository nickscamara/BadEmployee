using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{

    public GameObject panel;
    public GameObject spawner;


    void Start()
    {
        //TimedSpawn.stopSpawning = true;
        Debug.Log("on start");
        spawner.SetActive(false);
    }

    public void RestartScene()
    {

        panel.SetActive(false);
        //SceneManager.LoadScene("mobile");
        //TimedSpawn.stopSpawning = false;
        spawner.SetActive(true);
        Score.stop = false;
        Score.score = 0;

    }
}
