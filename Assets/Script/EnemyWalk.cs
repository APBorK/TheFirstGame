
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

[RequireComponent(typeof(NavMeshAgent))]

public class EnemyWalk : MonoBehaviour
{
    
    public float activeDistance = 10f;
    public float speed;
    public float startWaitTime;

    private Transform _target;
    private NavMeshAgent _myAgent;
    private float _waitTime;
    private Transform _spawnPosition;
    

    void Start ()
    {
        _waitTime = startWaitTime;
        _myAgent = GetComponent<NavMeshAgent>();
    }
    
    

    void Update ()
    {
        _target = PlayerInfo.player;
        if(Vector3.Distance(transform.position, _target.transform.position) < activeDistance)
        {
            transform.LookAt(_target.transform); 
            _myAgent.SetDestination(new Vector3(_target.position.x,_target.position.y,_target.position.z));
        }

        if (WayPoint.Contr == 0 && Vector3.Distance(transform.position, _target.transform.position) > activeDistance)
        {
            GoNPC();
        }


    }
    private void OnTriggerEnter(Collider spawn)
    {
        
        if (spawn.gameObject.CompareTag("Spawn"))
        {
            WayPoint.Contr = 1;
            Destroy(spawn.gameObject);
        }
    }

    void GoNPC()
    {
        var _spawnPosition = WayPointInfo.wayPoint;
        transform.LookAt(_spawnPosition.transform);
        _myAgent.SetDestination((new Vector3(_spawnPosition.position.x,_spawnPosition.position.y,_spawnPosition.position.z)));
    }

    
}
