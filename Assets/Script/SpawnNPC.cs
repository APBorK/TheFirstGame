using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNPC : MonoBehaviour
{
    public Transform Spawn;
    public GameObject objToSpawn;

    float maxX;
    float minX;
    float maxZ;
    float minZ;
    private int quantity = 10;
    void Start()
    {
        maxX = Spawn.position.x + Spawn.localScale.x / 2;
        minX = Spawn.position.x - Spawn.localScale.x / 2;

        maxZ = Spawn.position.z + Spawn.localScale.z / 2;
        minZ = Spawn.position.z - Spawn.localScale.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < quantity; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), Spawn.position.y, Random.Range(minZ, maxZ));
            Instantiate(objToSpawn, spawnPos, Quaternion.identity);
        }
        
    }
}
