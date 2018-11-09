﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{

    public GameObject spawnee;
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
        Instantiate(spawnee, transform.position, transform.rotation);
        Debug.Log(spawnee.GetComponent<Rigidbody2D>());
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}