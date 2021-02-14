using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speedShoot;
    public Transform gun;
    private CharacterController _controller;
    
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        Debug.DrawRay(gun.position, gun.forward * 10f);
    }
}
