using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    public Transform marble;
    //public Transform patrolRoute;
    //public List<Transform> locations;
    //private int locationIndex = 0;

    public ParticleSystem BlastCollision;
    private NavMeshAgent agent;
    private int _lives = 3;

    public int EnemyLives
    {
        get { return _lives; }
        private set
        {
            _lives = value;

            if (_lives <= 0)
            {
                BlastCollision.Play();
                Debug.Log("Enemy Destroyed!");
                Destroy(this.transform.gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Marble")
        {
            Debug.Log("Enemy Agent:: Target Detected!");
            agent.destination = marble.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.name == "Marble")
        {
            Debug.Log("Enemy Agent:: Target out of Range.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Blast(Clone)")
        {
            EnemyLives -= 1;
            Debug.Log(string.Format("You hit the enemy! " +
                "{0} lives remain.", EnemyLives));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        marble = GameObject.Find("Marble").transform;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
