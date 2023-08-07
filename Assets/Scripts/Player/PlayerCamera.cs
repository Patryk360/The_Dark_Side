using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;
    public Camera airplaneCamera;
    public GameObject airplane;
    
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
        
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            player.localScale = new Vector3(1, 0.5f, 1);
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            player.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            if (firstPersonCamera.enabled == true)
            {
                firstPersonCamera.enabled = false;
                thirdPersonCamera.enabled = true;
            }
            else if (thirdPersonCamera.enabled == true)
            {
                thirdPersonCamera.enabled = false;
                airplaneCamera.enabled = true;
            }
            else if (airplaneCamera.enabled == true)
            {
                airplaneCamera.enabled = false;
                firstPersonCamera.enabled = true;
            }
        }
    }
}