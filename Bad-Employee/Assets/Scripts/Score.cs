using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour {

    public static int score = 0;
    public int highscore = 0;
    public TextMeshProUGUI scoreTxt;

    //public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;

    public TimedSpawn s1;
    

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

        if (score >= 10)
        {
            s2.SetActive(true);
            TimedSpawn.spawnD(1.5f);
        }
        if (score >= 25)
        {
            s3.SetActive(true);
            TimedSpawn.spawnD(.2f);
            s2.SetActive(true);
            TimedSpawn.spawnD(.5f);
        }
        if (score >= 50)
        {
            s4.SetActive(true);
        }
        if (score >= 75)
        {
            s5.SetActive(true);
        }
    }
}
