using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemy : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        player = GameObject.FindWithTag("Player");
    }
    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag ("Player"))
        {
            agent.SetDestination(player.transform.position);    
        }
    }
}
