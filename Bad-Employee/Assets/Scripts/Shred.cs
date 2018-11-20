using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Shred : MonoBehaviour {

    public ParticleSystem ps;
    public ParticleSystem ps2;
    private RipplePostProcessor rp;
    public GameObject panel;
    public ParticleSystem bigExplosion;

  



    //this is for the floating points
    public TextMeshProUGUI points;
    public TextMeshProUGUI highscoreText;
    public Animator pointsp;

    public GameObject gj;

    public GameObject shreder;

    public static bool doublePoints = false;


    // Use this for initialization
    void Start () {

        rp = Camera.main.GetComponent<RipplePostProcessor>();
	}
	
	// Update is called once per frame
	void Update () {
        if (doublePoints)
        {
            
        }
        
    }
    IEnumerator MyCoroutine()
    {
        //This is a coroutine
        yield return new WaitForSeconds(1);
        panel.SetActive(true);
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
        bigExplosion.Stop();
            //Wait one frame
        
    }

 

    IEnumerator EffectDuration()
    {



        yield return new WaitForSeconds(10);
        shreder.transform.localScale = new Vector3(.39f, .39f, .39f);

    }
    IEnumerator DoublePointsDuration()
    {

        
        yield return new WaitForSeconds(10);
        doublePoints = false;

    }
private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Score.stop)
        {

            if (collision.gameObject.tag == "bonus")
            {
                if (!doublePoints)
                {
                    points.text = "+2";
                    Score.score += 2;
                }
                else
                {
                    points.text = "+4";
                    Score.score += 4;
                }
                gj.SetActive(true);
                //pointsp.Play("points");
                points.color = new Color(1, 0.52f, 0, 1);
                //pointsp.SetBool("points",true);

                ChangeColor.Cchange("bonus");
            }
            else if (collision.gameObject.tag == "losebox")
            {
                if (!doublePoints)
                {
                    points.text = "-1";
                    Score.score += -1;
                }
                else {
                    points.text = "-2";
                    Score.score += -2;
                }
                gj.SetActive(true);
                points.color = new Color(0.77f, 0.21f, 0.13f, 1);
                //pointsp.SetBool("points", true);

                ChangeColor.Cchange("lose");
            }
            else if (collision.gameObject.tag == "mysterybox")
            {

                gj.SetActive(true);
                points.color = new Color(0.49f, 0.12f, 0.65f, 1);
                //pointsp.SetBool("points", true);
                int a = Random.Range(2, 20);
                if (!doublePoints)
                {
                    points.text = "+" + a;
                    Score.score += a;
                }
                else {
                    points.text = "+" + a + "* 2 =" + 2 * a;
                    Score.score += 2*a;
                }
                ChangeColor.Cchange("mystery");
            }
            else if (collision.gameObject.tag == "blackbox")
            {
                if (!doublePoints)
                {
                    points.text = "-10";
                    Score.score += -10;
                }
                else {
                    points.text = "-20";
                    Score.score += -20;
                }
                gj.SetActive(true);
                points.color = new Color(0f, 0f, 0f, 1);
                //pointsp.SetBool("points", true);


                ChangeColor.Cchange("black");
            }
            else if (collision.gameObject.tag == "bomb")
            {
                points.text = "BOOOOM";
                Score.stop = true;
                gj.SetActive(true);
                points.color = new Color(0f, 0f, 0f, 1);
                // pointsp.SetBool("points", true);
                ChangeColor.Cchange("bomb");
                Debug.Log("You Lost");

                bigExplosion.Play();
                StartCoroutine(MyCoroutine());




                // Score.score = 0;
            }

            else if (collision.gameObject.tag == "bluepotion")
            {
                points.text = "Shrink it dude";
                gj.SetActive(true);
                points.color = new Color(0.23f, 0.855f, 1f);
                ChangeColor.Cchange("blue");
                shreder.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
                StartCoroutine(EffectDuration());


            }
            else if (collision.gameObject.tag == "redpotion")
            {
                points.text = "Bigger Dude";
                gj.SetActive(true);
                points.color = new Color(1f, 0.25f, 0.388f);
                ChangeColor.Cchange("red");
                shreder.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                StartCoroutine(EffectDuration());


            }
            else if (collision.gameObject.tag == "double")
            {
                points.text = "Double Points";
                gj.SetActive(true);
                points.color = new Color(0f, 1f, 0.071f);
                ChangeColor.Cchange("green");
                doublePoints = true;

                StartCoroutine(DoublePointsDuration());


            }
            else
            {
                if (!doublePoints)
                {
                    points.text = "+1";
                    Score.score += 1;
                }
                else
                
                    {
                        points.text = "+2";
                        Score.score += 2;
                    }
                    gj.SetActive(true);
                points.color = new Color(0.86f, 0.65f, 0.4f, 1);
                //pointsp.SetBool("points", true);
                ChangeColor.Cchange("box");
                
                
            }

            Debug.Log("Touched");
            BeltMovement.move = false;
            BeltMovement.destroy = true;
            Destroy(collision.gameObject); // maybe destroy the object
            rp.RippleEffect();

            ps.Play();
            ps2.Play();
        }
    }

   
}
