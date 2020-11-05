using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    public ParticleSystem BlastCollision;
    public Transform marble;
    private uint Obstacle_Health = 100;
    private NavMeshAgent agent;

    void Start(){
        agent = GetComponent<NavMeshAgent>();
        marble = GameObject.Find("Marble").transform;
    }

    void Update(){ }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Marble")
        {
            agent.destination = marble.position;
            Debug.Log("Enemy:: Targeting Systems Go!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Enemy:: Target Lost.");
    }

    void OnCollisionEnter(Collision collision)
    {
       //Put collision code here
       if (collision.gameObject.name == "Blast(Clone)")
        {
            //Decrease Obstacle's Health, Destroy if it reaches to 0

            if(Obstacle_Health - 50 == 0){
                Debug.Log("Bye bye enemy!!!");
                BlastCollision.Play();
                Destroy(this.transform.gameObject);
            }
            else
            {
                Obstacle_Health -= 50;
                Debug.Log("Enemy's Health decreased!!!");
            }
        }
    }
}
