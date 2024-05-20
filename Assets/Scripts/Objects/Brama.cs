using UnityEngine;

public class Brama : MonoBehaviour
{
    public Animator animator;
    public Camera mainCamera;
    public Canvas textCanvas;
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 6f))
        {
            if (hit.collider.CompareTag("brama"))
            {
                textCanvas.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    animator.SetBool("open", true);
                }
                if (Input.GetKeyUp(KeyCode.E))
                {
                    animator.SetBool("open", false);
                }
            }
            else
            {
                textCanvas.enabled = false;
            }
        }
    }
}