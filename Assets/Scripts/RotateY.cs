using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour
{
    public float rotateSpeed = 1.0f;
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
        // rotate behavior used L-shaped obstacle spin
        transform.Rotate(0, rotateSpeed, 0, Space.Self);
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
