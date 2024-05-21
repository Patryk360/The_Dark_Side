using UnityEngine;

public class keepItem : MonoBehaviour
{
    public Transform itemSpawnKeep;
    public Transform item;
    public Canvas keepItemCanvas;
    public Rigidbody itemRb;
    public Camera mainCamera;
    private bool _isHolding = false;
    public string holdItemName = "none"; 
    void FixedUpdate()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 6f))
        {
            if (hit.collider.CompareTag("keepItem"))
            {
                keepItemCanvas.enabled = true;
                if (Input.GetKey(KeyCode.E))
                {
                    itemRb.isKinematic = true;
                    _isHolding = true;
                    holdItemName = item.name;
                }
            }
            else
            {
                keepItemCanvas.enabled = false;
            }
        }
        if (Input.GetKey(KeyCode.Q))
        {
            itemRb.isKinematic = false;
            _isHolding = false;
            holdItemName = "none";
        }
        
        if (_isHolding)
        {
            item.transform.position = itemSpawnKeep.position;
            item.transform.rotation = itemSpawnKeep.rotation;
        }
    }
}
