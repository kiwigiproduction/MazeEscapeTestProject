using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMov : MonoBehaviour
{
    [SerializeField]
    private Transform targetPosition = null;

    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updatePosition = true;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(targetPosition.position);
    }
}
