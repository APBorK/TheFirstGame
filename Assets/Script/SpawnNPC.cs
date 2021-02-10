using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNPC : MonoBehaviour
{
    public Transform spawn;
    public GameObject objToSpawn;

    
    void Start()
    {
        Vector3 spawnPos = new Vector3(spawn.position.x,spawn.position.y,spawn.position.z);
        Instantiate(objToSpawn, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
