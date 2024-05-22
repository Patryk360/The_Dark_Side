using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Camera firstPersonCamera;
    public AudioListener firstPersonAudioListener;
    public Camera thirdPersonCamera;
    public AudioListener thirdPersonAudioListener;
    public Camera airplaneCamera;
    public AudioListener airplaneAudioListener;

    public Canvas menu;
    public Canvas chat;
    
    public Transform player;
    public Transform cam;
    public float sensitivity;
    public float smooth;
    public float x;
    public float y;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        if (chat.enabled)
        {
            return;
        }
        if (menu.enabled)
        {
            return;
        }
        x += Mathf.Lerp(0, Input.GetAxis("Mouse X") * sensitivity, 1f / smooth);
        y += Mathf.Lerp(0, Input.GetAxis("Mouse Y") * sensitivity, 1f / smooth);
        
        player.rotation = Quaternion.Euler(0, x, 0);
        cam.rotation = Quaternion.Euler(-y, x, 0);
        
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (firstPersonCamera.enabled)
            {
                firstPersonCamera.enabled = false;
                firstPersonAudioListener.enabled = false;
                thirdPersonAudioListener.enabled = true;
                thirdPersonCamera.enabled = true;
            }
            else if (thirdPersonCamera.enabled)
            {
                thirdPersonCamera.enabled = false;
                thirdPersonAudioListener.enabled = false;
                airplaneAudioListener.enabled = true;
                airplaneCamera.enabled = true;
            }
            else if (airplaneCamera.enabled)
            {
                airplaneCamera.enabled = false;
                airplaneAudioListener.enabled = false;
                firstPersonAudioListener.enabled = true;
                firstPersonCamera.enabled = true;
            }
        }
    }
}
