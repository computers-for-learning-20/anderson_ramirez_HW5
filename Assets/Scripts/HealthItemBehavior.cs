using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItemBehavior : MonoBehaviour
{

    public GameBehavior gameManager;
    public ParticleSystem collisionParticles; 

    void Start()
    {
        gameManager = GameObject.Find("GameManager")
            .GetComponent<GameBehavior>();

    }
    void OnCollisionEnter(Collision collision)
    {
        //Put collision code here
        if (collision.gameObject.name == "Marble")
        {

            //Update goals colected
            if (gameManager.HealthMarble < 100)
            {
                gameManager.HealthMarble += 10;
                Debug.Log("Yum! Health has been increased");
                collisionParticles.Play();
                // removed the collected health capsule
                Destroy(this.transform.gameObject);

            }
            else
            {
                gameManager.HealthMarble += 0;
                Debug.Log("You tried to use a health item, " +
                    "but your health was already at max.");
            }



        }
    }
}