using System;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float health = 100f;
    private void OnCollisionEnter(Collision col)
    {
        bool isBullet = (col.gameObject.tag == "Bullet");
        if (isBullet)
        {
            float collisionForce = col.impulse.magnitude;
            Debug.Log("Collision | " + collisionForce + " | " + health);
            health -= collisionForce;
            if (health <= 0)
            {
                Debug.Log("Dead");
                health = 100f;
            }
        }
    }
}
