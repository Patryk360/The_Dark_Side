using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public Transform sun;
    public float timeSpeed;
    void Start()
    {
        
    }
    void Update()
    {
        sun.rotation = Quaternion.Euler(Time.time * timeSpeed, Time.time * timeSpeed, Time.time * timeSpeed);
    }
}
