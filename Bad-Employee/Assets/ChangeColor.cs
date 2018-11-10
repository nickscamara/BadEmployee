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
    public static void Cchange(string s)
    {
        if (s.Equals("bonus"))
        {
            ps.startColor = new Color(1, 0.52f, 0, 1);
     
                }
        else {
            ps.startColor = new Color(0.86f, 0.65f, 0.4f, 1);
        }
        
    }
}
