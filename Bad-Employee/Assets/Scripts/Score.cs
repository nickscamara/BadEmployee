using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour {

    public static int score = 0;
    public int highscore = 0;
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI highscoreText;

    //public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;

    public TimedSpawn s1;

    public Sprite defaultsprite;
    public Sprite sprite;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;

    public SpriteRenderer cloud1;
    public SpriteRenderer cloud2;

    public SpriteRenderer spriteR;
    public static bool stop= false;

    

    // Use this for initialization
    void Start () {
        
        score = 0;
        //PlayerPrefs.SetInt("Highscore", 0);

        // scoreTxt = GetComponent<TextMeshProUGUI>();
    }
	
	// Update is called once per frame
	void Update () {

        scoreTxt.text = score.ToString();
        if (score >= PlayerPrefs.GetInt("Highscore"))
        {
            if (stop == true)
            {
                PlayerPrefs.SetInt("Highscore", score);
                
                highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
               // stop = false;
            }
        }

        if (score >= 10)
        {
            spriteR.sprite = sprite;
            s2.SetActive(true);
            TimedSpawn.spawnD(1.5f);
        }
        if (score >= 25)
        {
            cloud1.color = new Color(.56f, .35f, .80f);
            cloud2.color = new Color(.56f, .35f, .80f);
            spriteR.sprite = sprite2;
            s3.SetActive(true);
            TimedSpawn.spawnD(.2f);
            s2.SetActive(true);
            TimedSpawn.spawnD(.5f);
        }
        if (score >= 50)
        {
            cloud1.color = new Color(.39f, .39f, .39f);
            cloud2.color = new Color(.39f, .39f, .39f);
            spriteR.sprite = sprite3;
            s4.SetActive(true);
        }
        if (score >= 75)
        {
            cloud1.color = new Color(.7f, 1f, 1f);
            cloud2.color = new Color(.7f, 1f, 1f);
            spriteR.sprite = sprite4;
            s5.SetActive(true);
        }
        if (score >= 100)
        {
            cloud1.color = new Color(1f,.95f,.89f);
            cloud1.color = new Color(1f, .95f, .89f);
            spriteR.sprite = defaultsprite;
            s5.SetActive(true);
        }
        if (score >= 150)
        {
            cloud1.color = new Color(.56f, .35f, .80f);
            cloud2.color = new Color(.56f, .35f, .80f);
            spriteR.sprite = sprite;
            s2.SetActive(true);
            TimedSpawn.spawnD(.5f);
        }
        if (score >= 200)
        {
            cloud1.color = new Color(.56f, .35f, .80f);
            cloud2.color = new Color(.56f, .35f, .80f);
            spriteR.sprite = sprite2;
           
        }
    }
}
