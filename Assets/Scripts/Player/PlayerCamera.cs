using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform player;
    public Transform cam;
    public float sensitivity;
    public float x;
    public float y;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        y += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        
        y = Mathf.Clamp(y, -90, 90);
        
        player.rotation = Quaternion.Euler(0, x, 0);
        cam.rotation = Quaternion.Euler(-y, x, 0);
        
        if (Input.GetKey(KeyCode.F3))
        {
            
        }
        
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            player.localScale = new Vector3(1, 0.5f, 1);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            player.localScale = new Vector3(1, 1, 1);
        }
    }
}
