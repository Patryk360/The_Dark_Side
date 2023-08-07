using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XD : MonoBehaviour
{
    [HideInInspector] public bool isLanding = false;
    [HideInInspector] public float speed = 150;
    public Transform xd;
    void Start()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        isLanding = true;
    }
    void Update()
    {
        xd.position -= new Vector3(0, 0, speed) * Time.deltaTime;
        if (isLanding == true)
        {
            speed -= 0.7f;
            if (speed <= 0)
            {
                speed = 0;
            }
        }
    }
}
