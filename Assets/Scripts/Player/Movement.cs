using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform player;
    public float speed;
    public float jumpHeight;
    private float _x;
    private float _z;
    void FixedUpdate()
    {
        _x = Input.GetAxis("Horizontal");
        _z = Input.GetAxis("Vertical");
        player.Translate(_x * speed * Time.fixedDeltaTime, 0, _z * speed * Time.fixedDeltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Translate(0, jumpHeight, 0);
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 11;
        }
        else
        {
            speed = 5;
        }
    }
}
