using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    public GameBehavior gameManager; 
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();

    }
    void OnCollisionEnter(Collision collision)
    {
       //Put collision code here
       if ( collision.gameObject.name == "Blast(Clone)")
        {
            //Decrease Obstacle's Health, Destroy if it reaches to 0

            if(gameManager.HealthObstacle - 30 == 0){
                Debug.Log("Bye bye obstacle!!!");
                Destroy(this.transform.gameObject);
            }
            else{
                gameManager.HealthObstacle -= 30;
                Debug.Log("Obstacle's Health decreased!!!");
            }
        }
    }
}
