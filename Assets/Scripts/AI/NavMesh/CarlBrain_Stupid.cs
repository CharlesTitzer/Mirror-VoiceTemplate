using GDL_Tutorial;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarlBrain_Stupid : MonoBehaviour
{
    public Transform target;
    private EnemyReferences enemyReferences;
    private float shootingDistance;
    private float pathUpdateDeadline;

    private void Awake()
    {
        enemyReferences = GetComponent<EnemyReferences>();
    }

    void Start()
    {
        shootingDistance = enemyReferences.navMeshagent.stoppingDistance;
    }

    private void Update()
    {
        if (target != null)
        {
            bool inRange = Vector3.Distance(transform.position, target.position) <= shootingDistance;

            if (inRange)
            {
                LookAtTarget();
            } else
            {
                UpdatePath();
            }

            enemyReferences.animator.SetBool("Shooting", inRange);
        }
        enemyReferences.animator.SetFloat("speed", enemyReferences.navMeshagent.desiredVelocity.sqrMagnitude);
    }

    private void LookAtTarget()
    {
        Vector3 lookPos = target.position - transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        //smooth turn
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 0.2f);
    }

    private void UpdatePath()
    {
        if ( Time.time >= pathUpdateDeadline)
        {
            Debug.Log("Updating Path");
            pathUpdateDeadline = Time.time + enemyReferences.pathUpdateDelay;
            enemyReferences.navMeshagent.SetDestination(target.position);
        }
    }

}
