using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (isProvoked)
        {
            EngageTarget();
        }
        else if(distanceToTarget <= chaseRange)
        {
            isProvoked = true;
            navMeshAgent.SetDestination(target.position);
        }
    }

    private void EngageTarget()
    {
        if(distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }
        if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            AttackTarget();
        }
    }

    private void ChaseTarget()
    {
        GetComponent<Animator>().SetBool("attacked", false);
        GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.position);
    }

    private void AttackTarget()
    {
        GetComponent<Animator>().SetBool("attacked", true);
        print("You are being cuddled <3");
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0f, 0f, 0f, 0.75f);
        Gizmos.DrawSphere(transform.position, chaseRange);
    }
}
