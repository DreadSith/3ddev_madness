using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{

    public GameObject spawnee;
    public float spawnTime;
    public float spawnDelay;
    public float spawnUntil;
    int num = 0;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

    }

    public void SpawnObject()
    {
            Instantiate(spawnee, transform.position, transform.rotation);
            num++;


        if (num >= spawnUntil)
        {
            CancelInvoke("SpawnObject");
        }
    }

}

