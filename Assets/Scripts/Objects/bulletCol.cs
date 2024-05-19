using UnityEngine;

public class bulletCol : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GameObject hit = collision.gameObject;
        Debug.Log(hit.name);
        Destroy(gameObject);
    }
}
