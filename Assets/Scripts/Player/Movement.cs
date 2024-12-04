using UnityEngine;

public class Movement : MonoBehaviour
{
    public Canvas chat;
    public Transform player;
    public float speed;
    public float jumpHeight;
    private float _x;
    private float _z;
    void FixedUpdate()
    {
        if (chat.enabled)
        {
            return;
        }
        _x = Input.GetAxis("Horizontal");
        _z = Input.GetAxis("Vertical");
        player.Translate(_x * speed * Time.fixedDeltaTime, 0, _z * speed * Time.fixedDeltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            bool isGrounded = Physics.Raycast(player.position, Vector3.down, jumpHeight-0.2f);
            if (isGrounded) player.Translate(0, jumpHeight, 0);
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