using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public GameObject spawnee;
    public float spawnTime;
	
	// Update is called once per frame
	public void SpawnObject () {
            Instantiate(spawnee, transform.position, transform.rotation);
    }
}
