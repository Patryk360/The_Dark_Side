using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public AudioSource audioSource;
    public int speed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shot();
        }
    }
    
    void Shot()
    {
        audioSource.Play();
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation * Quaternion.Euler(90, 0, 0));
        bullet.name = System.Guid.NewGuid().ToString();
        
        Collider col = bullet.GetComponent<Collider>();
        col.enabled = true;
        
        Rigidbody rb = bullet.AddComponent<Rigidbody>();
        rb.mass = 5;
        rb.velocity = bulletSpawn.forward * speed;
    }
}