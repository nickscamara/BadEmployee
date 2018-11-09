using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    private static ParticleSystem ps;

	// Use this for initialization
	void Start () {
        ps = GetComponent<ParticleSystem>();
    }
	
	// Update is called once per frame
	void Update () {

        
    }
    public static void Cchange()
    {
        ps.startColor = new Color(255, 130, 0);
    }
}
