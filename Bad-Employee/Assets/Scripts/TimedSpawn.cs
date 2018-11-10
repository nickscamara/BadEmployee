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
    public float spawnTime = 1f;
    public float spawnDelay = 2f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        int a = Random.Range(0, 5);
        Instantiate(obj[a], transform.position, transform.rotation);
        Debug.Log(obj[a].GetComponent<Rigidbody2D>());
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}