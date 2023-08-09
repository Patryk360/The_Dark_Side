using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public Light lightFlash;
    public Transform flashLight;
    public Transform cam;
    public float speed;
    public bool flashLightEnabled;
    void Start()
    {
        lightFlash.enabled = false;
    }
    void Update()
    {
        flashLight.position = Vector3.Slerp(flashLight.position, cam.position, speed);
        flashLight.rotation = Quaternion.Slerp(flashLight.rotation, cam.rotation, speed);
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashLightEnabled)
            {
                flashLightEnabled = false;
                lightFlash.enabled = false;
            }
            else
            {
                flashLightEnabled = true;
                lightFlash.enabled = true;
            }
        }
    }
}
