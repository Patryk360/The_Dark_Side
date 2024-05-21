using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [HideInInspector] public bool isLanding = false;
    public float speed = 150;
    public Transform xd;
    void OnCollisionEnter(Collision col)
    {
        isLanding = true;
    }
    void Update()
    {
        xd.position -= new Vector3(0, 0, speed) * Time.deltaTime;
        if (isLanding == true)
        {
            speed -= 0.1f;
            if (speed <= 0)
            {
                speed = 0;
            }
        }
    }
}
