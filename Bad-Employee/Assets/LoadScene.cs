using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour {

    public GameObject panel;
    

    void OnStart()
    {
        
    }

    public void RestartScene()
    {
        
            panel.SetActive(false);
            SceneManager.LoadScene("mobile");
            Score.stop = false;
            Score.score = 0;
        
    }
}
