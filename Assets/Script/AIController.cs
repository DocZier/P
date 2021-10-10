using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public NavMeshAgent ag;
    public Transform tar;
    void Start()
    {
        ag = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tar)
        {
            ag.SetDestination(tar.position);
        }
    }
}
