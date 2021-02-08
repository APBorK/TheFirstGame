using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;
    private NavMeshAgent myAgents;
    private float speed = 8f;

    void Start()
    {
        myAgents = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        //Движение
        if (Input.GetMouseButton(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(myRay,out hitInfo,100,whatCanBeClickedOn))
            {
                myAgents.SetDestination(hitInfo.point);
            }

            myAgents.speed = speed;
        }
        if (Input.GetMouseButton(1))
        {
            myAgents.speed = speed * 2;
        }
        //...
        
        
    }
}
