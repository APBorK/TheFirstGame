
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyWalk : MonoBehaviour
{
    
    public float activeDistance = 10f;
    public float speed;
    
    private Transform _target;
    private NavMeshAgent _myAgent;
    private bool _isMove;
    

    void Start () 
    {
        _myAgent = GetComponent<NavMeshAgent>();
        _myAgent.SetDestination(Vector3.zero);

    }
    

    void Update ()
    {
        
        _target = PlayerInfo.player;
        if(Vector3.Distance(transform.position, _target.transform.position) < activeDistance)
        {
            transform.LookAt(_target.transform); 
            _myAgent.SetDestination(new Vector3(_target.position.x,_target.position.y,_target.position.z));
        }
        if(!_isMove)
        { 
            
          
        }
        
    }

    void RandomWayPoint()
    {
        _myAgent.SetDestination(new Vector3(Random.Range(-95,95),_target.position.y,Random.Range(-95,95)));
    }
}
