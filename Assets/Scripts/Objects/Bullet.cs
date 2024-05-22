using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public Transform recoinCamera;
    public Transform player;
    public AudioSource audioSource;
    public int bulletSpeed;
    public int rateOfFire;
    public int magazine;
    public bool onFire;

    private keepItem test;

    private void Start()
    {
        test = FindObjectOfType<keepItem>();
    }

    void Update()
    {
        //Debug.Log(test.holdItemName);
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (onFire)
            {
                Shot();
                
                onFire = false;
            }
            rateOfFire -= 1;
            if (rateOfFire == 0)
            {
                onFire = true;
                rateOfFire = 10;
            }
        }
    }
    
    void Shot()
    {
        audioSource.Play();
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation * Quaternion.Euler(90, 0, 0));
        bullet.name = Guid.NewGuid().ToString();
        
        Collider col = bullet.GetComponent<Collider>();
        MeshRenderer mesh = bullet.GetComponent<MeshRenderer>();
        Light shine = bullet.GetComponent<Light>();
        col.enabled = true;
        mesh.enabled = true;
        shine.enabled = true;
        
        Rigidbody rb = bullet.AddComponent<Rigidbody>();
        rb.mass = 10;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        rb.velocity = bulletSpawn.forward * bulletSpeed;
    }
}