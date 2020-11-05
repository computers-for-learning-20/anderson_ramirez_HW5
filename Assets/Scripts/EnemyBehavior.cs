using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public ParticleSystem BlastCollision;
    public Transform marble;
    private uint Obstacle_Health = 100;
    private UnityEngine.AI.NavMeshAgent agent;

    void Start(){
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        marble = GameObject.Find("Marble").transform;
    }

    void Update(){
        agent.destination = marble.position;
    }

    void OnCollisionEnter(Collision collision)
    {
       //Put collision code here
       if (collision.gameObject.name == "Blast(Clone)")
        {
            //Decrease Obstacle's Health, Destroy if it reaches to 0

            if(Obstacle_Health - 50 == 0){
                Debug.Log("Bye bye obstacle!!!");
                BlastCollision.Play();
                Destroy(this.transform.gameObject);
            }
            else{
                Obstacle_Health -= 50;
                Debug.Log("Obstacle's Health decreased!!!");
            }
        }
    }
}
