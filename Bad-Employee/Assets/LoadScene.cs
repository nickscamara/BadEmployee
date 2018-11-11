using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour {

    public GameObject panel;

    public void RestartScene()
    {
        SceneManager.LoadScene("mobile");
        Score.score = 0;
        panel.SetActive(false);
    }
}
