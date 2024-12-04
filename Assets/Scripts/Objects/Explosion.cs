using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource explosion;
    private bool _play = true; 
    void OnCollisionEnter(Collision coll)
    {
        if (_play) explosion.Play();
        _play = false;
    }
}