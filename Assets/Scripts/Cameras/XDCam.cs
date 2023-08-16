using UnityEngine;

public class XDCam : MonoBehaviour
{
    public Transform cam;
    public float sensitivity;
    public float x;
    public float y;
    void Update()
    {
        x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        y += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        
        cam.rotation = Quaternion.Euler(-y, x, 0);
    }
}