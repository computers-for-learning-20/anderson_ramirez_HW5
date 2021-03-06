﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleBehavior : MonoBehaviour
{
    private uint Obstacle_Health = 100;
    public ParticleSystem BlastCollision;

    public Material DamagedBodyMaterial;
    public Renderer Object;

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
            else
            {
                Object.material = DamagedBodyMaterial;
                Obstacle_Health -= 50;
                Debug.Log("Obstacle's Health decreased!!!");
            }
        }
    }
}
