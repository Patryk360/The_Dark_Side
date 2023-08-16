using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Rigidbody bulletRigidbody;
    public Camera mainCamera;
    public AudioSource audioSource;
    public int speed = 5;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }
    
    void Shot()
    {
        audioSource.Play();
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bulletRigidbody.AddForce(mainCamera.transform.forward * speed, ForceMode.Impulse);
    }
}