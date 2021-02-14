using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointInfo : MonoBehaviour
{
    public static Transform wayPoint;

    private void Start()
    {
        FindPlayer();
    }

    public void Update()
    {
        FindPlayer();
    }

    public static void FindPlayer() 
    {
        wayPoint = GameObject.FindGameObjectWithTag("Spawn").transform;
    }

 }
