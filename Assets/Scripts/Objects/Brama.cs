using UnityEngine;

public class Brama : MonoBehaviour
{
    public Animator animator;
    public Camera mainCamera;
    public Canvas textCanvasOpen;
    public Canvas textCanvasClose;
    void FixedUpdate()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 6f))
        {
            if (hit.collider.CompareTag("brama"))
            {
                if (!animator.GetBool("open"))
                {
                    textCanvasOpen.enabled = true;
                    textCanvasClose.enabled = false;
                }

                if (animator.GetBool("open"))
                {
                    textCanvasClose.enabled = true;
                    textCanvasOpen.enabled = false;
                }
                if (Input.GetKey(KeyCode.E))
                {
                    animator.SetBool("open", true);
                }
                if (Input.GetKey(KeyCode.Q))
                {
                    animator.SetBool("open", false);
                }
            }
            else
            {
                textCanvasOpen.enabled = false;
                textCanvasClose.enabled = false;
            }
        }
    }
}