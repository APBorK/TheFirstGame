using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public int speed = 3;
    
    private Vector3 lastPos;

    private void Start()
    {
        lastPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        RaycastHit hitInfo;

        Debug.DrawLine(lastPos, transform.position);
        if (Physics.Linecast(lastPos, transform.position, out hitInfo))
        {
            print(hitInfo.transform.name);

        }
        lastPos = transform.position;
    }
}
