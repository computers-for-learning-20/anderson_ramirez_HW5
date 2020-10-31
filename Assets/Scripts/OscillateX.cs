
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillateX : MonoBehaviour
{

    public float moveSpeed = 0.1f;
    public float delta = 45f;
    private Vector3 startPos;
    private uint Obstacle_Health = 100;

    // Start is called before the first frame update
    void Start()
    {
        this.startPos = this.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPos = startPos;
        newPos.x += delta * Mathf.Sin(Time.time * moveSpeed);
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
