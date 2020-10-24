using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{

    public ParticleSystem GoalParticles;
    public ParticleSystem GoalCollision;

    void OnCollisionEnter(Collision collision)
    {
       //Put collision code here
       if ( collision.gameObject.name == "Marble")
        {
            // triggers the burst of white
            // particles and stops the small yellow ones
            GoalCollision.Play();
            Destroy(GoalParticles);

            // removed the collected goal
            Destroy(this.transform.gameObject);
            Debug.Log("Goal!!!");
        }
    }
}
