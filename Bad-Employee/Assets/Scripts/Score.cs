using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour {

    public static int score = 0;
    public int highscore = 0;
    public TextMeshProUGUI scoreTxt;

	// Use this for initialization
	void Start () {

        score = 0;
       // scoreTxt = GetComponent<TextMeshProUGUI>();
    }
	
	// Update is called once per frame
	void Update () {

        scoreTxt.text = score.ToString();
        if (score >= PlayerPrefs.GetInt("Highscore"))
        {
         


            PlayerPrefs.SetInt("Highscore", score);
        }
    }
}
