using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public LayerMask whatCanBeClickedOn;
    public float distance = 100f;
    private NavMeshAgent myAgents;
    private float speed = 8f;
    

    void Start()
    {
        myAgents = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MovePlayer();
        }
        if (Input.GetMouseButton(1))
        {
            RunPlayer();
        }
    }

    private void MovePlayer()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay,out hitInfo,distance,whatCanBeClickedOn))
        {
            myAgents.SetDestination(hitInfo.point);
        }

        myAgents.speed = speed;
    }

    private void RunPlayer()
    {
        myAgents.speed = speed * 2;
    }
}
