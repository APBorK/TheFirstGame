
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyWalk : MonoBehaviour
{
    
    public float activeDistance = 10f;
    public float speed;
    public Transform[] moveSpots;
    public float startWaitTime;
    
    private Transform _target;
    private NavMeshAgent _myAgent;
    private int _randomSpot ;
    private float _waitTime;
    

    void Start ()
    {
        _waitTime = startWaitTime;
        _myAgent = GetComponent<NavMeshAgent>();
        RandomWayPoint();
    }
    
    

    void Update ()
    {
        
        _target = PlayerInfo.player;
        if(Vector3.Distance(transform.position, _target.transform.position) < activeDistance)
        {
            transform.LookAt(_target.transform); 
            _myAgent.SetDestination(new Vector3(_target.position.x,_target.position.y,_target.position.z));
        }
        else
        {
            transform.position =  Vector3.MoveTowards(transform.position, moveSpots[RandomWayPoint()].position,
                speed * Time.deltaTime);
            transform.LookAt(transform.position);
            _myAgent.SetDestination(transform.position);
            if (Vector3.Distance(transform.position,moveSpots[_randomSpot].position)< 0.2f)
            {
                RandomWayPoint();
                _waitTime = startWaitTime;
            }
            else
            {
                _waitTime -= Time.deltaTime;
            }
        }
    }

    int RandomWayPoint()
    {
        _randomSpot = Random.Range(0, moveSpots.Length);
        return 0;
    }
}
