using UnityEngine;

public class PlanePreCollision : MonoBehaviour
{
    public AudioSource allah;
    private bool _play = true; 
    void OnTriggerEnter(Collider coll)
    {
        if (_play) allah.Play();
        _play = false;
    }
}