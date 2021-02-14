using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WayPoint : MonoBehaviour
{
    public Transform spawn;
    public GameObject ObjToSpawn;
    public static int Contr;

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
        СreateWaypoints();
    }

    private void Update()
    {
        if (WayPointInfo.wayPoint == null && Contr == 1)
        {
            СreateWaypoints();
        }
    }

    public void СreateWaypoints()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(_minX,_maxX),spawn.position.y + 1,
            Random.Range(_minZ,_maxZ));
        Instantiate(ObjToSpawn, spawnPosition, Quaternion.identity);
        Contr = 0;
    }

    
}
