using System;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Glass"))
        {
            audioSource.Play();
        }
    }
}
