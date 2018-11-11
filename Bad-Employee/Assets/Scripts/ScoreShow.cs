using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreShow : MonoBehaviour {

	// Use this for initialization
	void Start () {
       

        GetComponent<TextMeshProUGUI>().text = Score.score.ToString();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
