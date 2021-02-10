using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;
    private NavMeshAgent myAgents;
    public Transform[] move;
  

    void Start()
    {
        myAgents = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        //Движение
        
       
    }

    private void OnTriggerEnter(Collider shit)
    {
        if (shit.gameObject.tag == "Spawn1")
        {
            Ray myRay = Camera.main.ScreenPointToRay(move[0].position);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay, out hitInfo, 100, whatCanBeClickedOn))
            {
                myAgents.SetDestination(hitInfo.point);
            }
            
        }
        
        if (shit.gameObject.tag == "Spawn2")
        {
            Ray myRay = Camera.main.ScreenPointToRay(move[1].position);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay, out hitInfo, 100, whatCanBeClickedOn))
            {
                myAgents.SetDestination(hitInfo.point);
            }
            
        }
        
        if (shit.gameObject.tag == "Spawn3")
        {
            Ray myRay = Camera.main.ScreenPointToRay(move[2].position);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay, out hitInfo, 100, whatCanBeClickedOn))
            {
                myAgents.SetDestination(hitInfo.point);
            }
            
        }
    }
}
