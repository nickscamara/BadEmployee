using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{

    public GameObject[] obj;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;

    public bool stopSpawning = false;
    public static  float spawnTime = 1f;
    public static float spawnDelay = 2f;

   // private static  GameObject gameObject;
    // Use this for initialization
    void Start()
    {
       // gameObject = GetComponent<GameObject>();
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        int a = Random.Range(0, 13);
        Instantiate(obj[a], transform.position, transform.rotation);
        Debug.Log(obj[a].GetComponent<Rigidbody2D>());
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }

    public static void Activates()
    {
        //gameObject.SetActive(true);
    }

    public static void spawnT(float time)
    {
        spawnTime = time;
    }

    public static void spawnD(float delay)
    {
        spawnDelay = delay;
    }
}