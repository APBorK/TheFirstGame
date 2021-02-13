using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyWalk : MonoBehaviour {
    
    public Transform[] wayPoints;
    public float stoppingDistance = 5;
    public float timeWait = 3;
    public float rotationSpeed = 5;
    public Transform defLook;
    public float activeDistance = 10f;
    public float speed;
    
    private Vector3 _target;
    private float _curTimeout;
    private int _wayCount;
    private bool _isTarget;
    

    private NavMeshAgent _myAgent;

    void Start () 
    {
        _myAgent = GetComponent<NavMeshAgent>();
        
    }

    void SetRotation(Vector3 lookAt)
    {
        Vector3 lookPos = lookAt - transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

    void Update ()
    {
        var position = PlayerInfo.player.position;
        _target = position;
        float dis = Vector3.Distance (transform.position, position);
        if(dis < activeDistance)
        {
            _isTarget = true;
        }
		
        if(wayPoints.Length >= 2 && !_isTarget)
        {
            _myAgent.stoppingDistance = 0;
            _myAgent.SetDestination(wayPoints[_wayCount].position);
            if(!_myAgent.hasPath)
            {
                SetRotation(defLook.position);
                _curTimeout += Time.deltaTime;
                if(_curTimeout > timeWait)
                {
                    _curTimeout = 0; 
                    if(_wayCount < wayPoints.Length-1)
                        _wayCount++; 
                    else _wayCount = 0;
                    
                }
            }
        }
        else if(wayPoints.Length == 0 || _isTarget)
        {
            _myAgent.stoppingDistance = stoppingDistance;
            _myAgent.SetDestination(_target);
            if(_myAgent.velocity == Vector3.zero) SetRotation(_target);
        }
    }
}
