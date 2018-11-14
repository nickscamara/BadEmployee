using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Shred.doublePoints == true)
        {
            if (collision.gameObject.tag == "double")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
