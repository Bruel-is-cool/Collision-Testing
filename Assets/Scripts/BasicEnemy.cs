using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemy : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag ("Player"))
        {
            agent.SetDestination(player.transform.position);    
        }
    }
}
