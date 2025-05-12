using UnityEngine;
using UnityEngine.AI;

public class MouseController : MonoBehaviour
{
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void MoveTo(Vector3 destination)
    {
        agent.SetDestination(destination);
    }
}
