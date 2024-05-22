using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetBool("door_open", true);
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            animator.SetBool("door_open", false);
        }
    }
}
