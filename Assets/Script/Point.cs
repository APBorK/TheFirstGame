using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Transform spawn;
    public GameObject[] objToSpawn;

    float minX;
    float minZ;
    float maxX;
    float maxZ;
    

    
    void Start()
    {
        maxX = spawn.position.x + spawn.localScale.x / 2;
        minX = spawn.position.x - spawn.localScale.x / 2;
        
        maxZ = spawn.position.z + spawn.localScale.z / 2;
        minZ = spawn.position.z - spawn.localScale.z / 2;

        for (int i = 0; i < objToSpawn.Length; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX,maxX),spawn.position.y,Random.Range(minZ,maxZ));
            Instantiate(objToSpawn[i], spawnPos, Quaternion.identity);
        }
    }
    
}
