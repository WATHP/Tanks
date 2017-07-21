using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform player;
    public float distance = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (GameObject.FindGameObjectWithTag("Player") == null) player = transform;
        else player = GameObject.FindGameObjectWithTag("Player").transform;


    }

    private void Update()
    {
        if (player == null) { player = this.gameObject.transform; }
        if (Vector3.Distance(transform.position, player.position) < distance) 
        {
            agent.isStopped = true;
        }
        else
        {
            agent.isStopped = false;
            agent.SetDestination(player.position);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.collider.GetComponent<TankHealth>().hp -= 50;
            ParticleSystem a = GameObject.Find("TankExplosion").GetComponent<ParticleSystem>();
            a.Play();
            GetComponent<EnemyMove>().enabled = false;
            GetComponent<EnemyHealth>().enabled = false;
            Destroy(this.gameObject, 0.3f);

        }
    }
}
