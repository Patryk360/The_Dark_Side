using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("run", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("run", false);
        }
    }
}