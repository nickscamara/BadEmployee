using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Shred : MonoBehaviour {

    public ParticleSystem ps;
    public ParticleSystem ps2;
    private RipplePostProcessor rp;
    public GameObject panel;

	// Use this for initialization
	void Start () {

        rp = Camera.main.GetComponent<RipplePostProcessor>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator MyCoroutine()
    {
        //This is a coroutine
       

        yield return new WaitForSeconds(8);    //Wait one frame

        Score.score = 0;
        panel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "bonus")
        {
            Score.score += 2;
            ChangeColor.Cchange("bonus");
        }
        else if (collision.gameObject.tag == "losebox")
        {
            Score.score += -1;
            ChangeColor.Cchange("lose");
        }
        else if (collision.gameObject.tag == "mysterybox")
        {
            int a = Random.Range(-20, 20);
            Score.score += a;
            ChangeColor.Cchange("mystery");
        }
        else if (collision.gameObject.tag == "bomb")
        {
            Debug.Log("You Lost");
            panel.SetActive(true);

           
                StartCoroutine(MyCoroutine());
            

           

            // Score.score = 0;
        }
        else
        {
            ChangeColor.Cchange("box");
            Score.score += 1;
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
