using UnityEngine;
using WebSocketSharp;

public class WebSocketManager
{
    private static WebSocket webSocket;
    public static void StartWebSocket()
    {
        webSocket = new WebSocket("ws://localhost:8080");
        webSocket.Connect();

        webSocket.OnError += (sender, e) =>
        {
            Debug.Log("WS: Error - " + e.Message);
        };

        webSocket.OnClose += (sender, e) =>
        {
            Debug.Log("WS: Close");
        };

        webSocket.OnMessage += (sender, e) =>
        {
            PlayerJoin.Join();
            Debug.Log("WS: " + e.Data);
        };
    }
    public static void SendWebSocketMessage(string message)
    {
        if (webSocket != null && webSocket.ReadyState == WebSocketState.Open)
        {
            webSocket.Send(message);
        } else
        {
            Debug.Log("WS: Not connected");
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