using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillateZ : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public float delta = 35f;
    private uint Obstacle_Health = 100;
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        this.startPos = this.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPos = startPos;
        newPos.z += delta * Mathf.Sin(Time.time * moveSpeed);
        transform.position = newPos;
    }

    void OnCollisionEnter(Collision collision)
    {
       //Put collision code here
       if (collision.gameObject.name == "Blast(Clone)")
        {
            //Decrease Obstacle's Health, Destroy if it reaches to 0

            if(Obstacle_Health - 50 == 0){
                Debug.Log("Bye bye obstacle!!!");
                Destroy(this.transform.gameObject);
            }
            else{
                Obstacle_Health -= 50;
                Debug.Log("Obstacle's Health decreased!!!");
            }
        }
    }
}

