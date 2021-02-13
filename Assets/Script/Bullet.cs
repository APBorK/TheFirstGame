using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float speedShoot = 10;
    public float repulsion = 3;
    public float damage = 25;

    private Vector3 _lastPosition;

    private void Start()
    {
        _lastPosition = transform.position;
    }

    void Update()
    {
       transform.Translate(Vector3.forward * (speedShoot * Time.deltaTime));
       RaycastHit hitInfo;
       if (Physics.Linecast(_lastPosition, transform.position, out hitInfo))
       {
           if (hitInfo.transform.tag == "Wall")
           {
               repulsion--;
               speedShoot *= -1;
               if (repulsion == 0)
               {
                   Destroy(gameObject);
               }
               
           }

           /*if (hitInfo.transform.tag == "Bot")
           {
               hitInfo.transform.gameObject.GetComponent<BotHealth>().Hit(damage);
               Destroy(gameObject);
           }
           */
       }

       _lastPosition = transform.position;
    }
}
