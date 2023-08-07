using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using WebSocketSharp;

public class WS : MonoBehaviour
{
    WebSocket webSocket;
    void Start()
    {
        webSocket = new WebSocket("ws://localhost:8080");
        webSocket.Connect();
        webSocket.OnMessage += (sender, e) =>
        {
            Debug.Log("WS: " + e.Data);
        };
        
    }
    void Update()
    {
        if (webSocket == null) return;
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            webSocket.Send("Hello from Unity!");
        }
    }
}
