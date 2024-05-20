using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform player;
    public float speed;
    public float jumpHeight;
    private float _x;
    private float _z;
    void Update()
    {
        _x = Input.GetAxis("Horizontal");
        _z = Input.GetAxis("Vertical");
        player.Translate(_x * speed * Time.deltaTime, 0, _z * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Translate(0, jumpHeight, 0);
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 15;
        }
        else
        {
            speed = 5;
        }
    }
}
