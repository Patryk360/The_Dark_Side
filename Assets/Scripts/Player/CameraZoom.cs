using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera cameraZoom;
    public float zoomSpeed = 1.0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            cameraZoom.fieldOfView -= zoomSpeed;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            cameraZoom.fieldOfView += zoomSpeed;
        }
    }
}
