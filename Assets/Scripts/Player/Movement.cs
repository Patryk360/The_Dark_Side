using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform player;
    public float speed;
    public float jumpHeight;
    public float x;
    public float y;
    public float z;
    void Start()
    {
        
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Jump");
        z = Input.GetAxis("Vertical");
        player.Translate(x * speed * Time.deltaTime, 0, z * speed * Time.deltaTime);
        if (y > 0)
        {
            player.Translate(0, y * jumpHeight * Time.deltaTime, 0);
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 15;
        }
        else
        {
            speed = 5;
        }
    }
}
