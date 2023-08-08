using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public Transform playerTransform;
    private void Update()
    {
        WebSocketManager.Instance.SendWebSocketMessage(playerTransform.position.x + "," + playerTransform.position.y + "," + playerTransform.position.z);
    }
}