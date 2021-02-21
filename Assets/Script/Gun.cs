using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform gun;
    public GameObject bullet;
    public float attackDistance = 10f;
    private Transform _target;
    private CharacterController _controller;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        _target = EnemyInfo.bot;
        Debug.DrawRay(gun.position, gun.forward * 10f);
        if (Vector3.Distance(transform.position, _target.transform.position) < attackDistance)
        {
            transform.LookAt(_target.transform);
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, gun.position, gun.rotation);
    }
}
