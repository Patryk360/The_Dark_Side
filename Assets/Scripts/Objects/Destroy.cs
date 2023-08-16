using System;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Glass")
        {
            audioSource.Play();
        }
    }
}
