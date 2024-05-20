using UnityEngine;
using WebSocketSharp;

public class WebSocketManager
{
    private static WebSocket webSocket;
    public static void StartWebSocket()
    {
        webSocket = new WebSocket("ws://localhost:3000");
        webSocket.Connect();

        webSocket.OnError += (sender, e) =>
        {
            Debug.LogWarning("WS: Error - " + e.Message);
        };

        webSocket.OnClose += (sender, e) =>
        {
            Debug.LogWarning("WS: Close");
        };

        webSocket.OnMessage += (sender, e) =>
        {
            PlayerJoin.Join();
            Debug.LogWarning("WS: " + e.Data);
        };
    }
    public static void SendWebSocketMessage(string message)
    {
        if (webSocket != null && webSocket.ReadyState == WebSocketState.Open)
        {
            webSocket.Send(message);
        }
    }
    public static void StopWebSocket()
    {
        if (webSocket != null)
        {
            webSocket.Close();
        }
    }
    public static bool IsConneted()
    {
        return webSocket != null && webSocket.ReadyState == WebSocketState.Open;
    }
}