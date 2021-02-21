using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehaviour : MonoBehaviour
{
    public int MaxHealth;
    public int Health;

    private void Awake()
    {
        MaxHealth = 100;
        Health = 100;
    }
}
