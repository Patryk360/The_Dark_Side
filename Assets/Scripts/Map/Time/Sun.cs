using UnityEngine;

public class Sun : MonoBehaviour
{
    public Transform sun;
    public float timeSpeed;
    void Update()
    {
        sun.rotation = Quaternion.Euler(Time.time * timeSpeed, Time.time * timeSpeed, Time.time * timeSpeed);
    }
}