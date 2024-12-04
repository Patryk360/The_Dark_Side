using System;
using UnityEngine;
using Newtonsoft.Json;

public class PlayerData
{
    public string Type { get; set; }
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public string PlayerID { get; set; }
}

public class MainPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public string playerID;
    private void Start()
    {
        Guid newGuid = Guid.NewGuid();
        playerID = newGuid.ToString("N");

        WebSocketManager.StartWebSocket("ws://localhost:3000");
    }
    private void Update()
    {
        PlayerData playerData = new PlayerData
        {
            Type = "playerMove",
            X = playerTransform.position.x,
            Y = playerTransform.position.y,
            Z = playerTransform.position.z,
            PlayerID = playerID
        };
        
        string json = JsonConvert.SerializeObject(playerData);
        
        WebSocketManager.SendWebSocketMessage(json);
    }
}