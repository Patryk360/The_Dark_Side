using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XD : MonoBehaviour
{
    public Transform xd;
    void Start()
    {
        
    }
    void Update()
    {
        xd.position -= new Vector3(0, 0, 150) * Time.deltaTime;
    }
}
