using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public int speed = 3;
    public LayerMask collisionMasck;
    
    private Vector3 lastPos;

    private void Start()
    {
        lastPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        RaycastHit hitInfo;
        
        Ray ray = new Ray(transform.position,
            transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Time.deltaTime *
            speed + 0.1F, collisionMasck))
        {
            Vector3 refclectDir = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(refclectDir.z, refclectDir.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
        }

        Debug.DrawLine(lastPos, transform.position);
        if (Physics.Linecast(lastPos, transform.position, out hitInfo))
        {
            print(hitInfo.transform.name);
            

        }
        lastPos = transform.position;
    }
}
