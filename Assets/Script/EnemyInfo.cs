using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfo : MonoBehaviour
{
    public static Transform bot;

    void Start()
    {
        FindNPC();
    }

    public static void FindNPC() 
    {
        bot = GameObject.FindGameObjectWithTag("Bot").transform;
    }
}
