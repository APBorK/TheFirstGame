using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointInfo : MonoBehaviour
{
    public static Transform wayPoint;
    private Rigidbody _rigidbody;
    

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (gameObject.CompareTag("Spawn1"))
        {
            wayPoint = GameObject.FindGameObjectWithTag("SpawnPoint1").transform;
        }
    }


    void OnTriggerEnter(Collider bot)
    {
       

         /*if (bot.gameObject.CompareTag("Spawn2"))
         {
             wayPoint[1] = GameObject.FindGameObjectWithTag("SpawnPoint2").transform;
         }

         if (bot.gameObject.CompareTag("Spawn3"))
         { 
             wayPoint[2] = GameObject.FindGameObjectWithTag("SpawnPoint3").transform;
         }*/
     }

 }
