using System;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public string playerID;
    private void Start()
    {
        Guid newGuid = Guid.NewGuid();
        playerID = newGuid.ToString("N");
        WebSocketManager.StartWebSocket();
    }
    private void Update()
    {
        WebSocketManager.SendWebSocketMessage(playerTransform.position.x + "," + playerTransform.position.y + "," + playerTransform.position.z + "," + playerID);
    }
}