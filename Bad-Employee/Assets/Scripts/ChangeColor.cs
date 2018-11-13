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
        else if (s.Equals("lose"))
        {
            ps.startColor = new Color(0.77f, 0.21f, 0.13f, 1);
        }
        else if (s.Equals("mystery"))
        {
            ps.startColor = new Color(0.49f, 0.12f, 0.65f, 1);
        }
        else if (s.Equals("bomb"))
        {
            ps.startColor = new Color(0f, 0f, 0f, 1);
        }
        else if (s.Equals("black"))
        {
            ps.startColor = new Color(0f, 0f, 0f, 1);
        }
        else if (s.Equals("blue"))
        {
            ps.startColor = new Color(0.23f, 0.855f, 1f);
        }
        else if (s.Equals("red"))
        {
            ps.startColor = new Color(1f, 0.25f, 0.388f);
        }
        else if (s.Equals("double"))
        {
            ps.startColor = new Color(0f, 1f, 0.71f);

        }
        else
        {
            ps.startColor = new Color(0.86f, 0.65f, 0.4f, 1);
        }
        
    }
}
