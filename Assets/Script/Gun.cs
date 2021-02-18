using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform gun;
    public GameObject bullet;
    public float attackDistance = 2f;
    private CharacterController _controller;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        Debug.DrawRay(gun.position, gun.forward * 10f);
        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, gun.position, gun.rotation);
    }
}
