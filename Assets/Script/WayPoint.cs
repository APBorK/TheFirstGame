using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public Transform spawn;
    public GameObject[] objToSpawn;

    float _minX;
    float _minZ;
    float _maxX;
    float _maxZ;
    

    
    void Start()
    {
        var position = spawn.position;
        var localScale = spawn.localScale;
        
        _maxX = position.x + localScale.x / 2;
        _minX = position.x - localScale.x / 2;
        
        _maxZ = position.z + localScale.z / 2;
        _minZ = position.z - localScale.z / 2;

        for (int i = 0; i < objToSpawn.Length; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(_minX,_maxX),spawn.position.y,Random.Range(_minZ,_maxZ));
            Instantiate(objToSpawn[i], spawnPos, Quaternion.identity);
        }
    }
    
}
