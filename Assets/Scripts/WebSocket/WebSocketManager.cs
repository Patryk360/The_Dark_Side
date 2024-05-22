using UnityEngine;
using WebSocketSharp;

public class WebSocketManager : MonoBehaviour
{
    private static WebSocket webSocket;

    public static void StartWebSocket(string url)
    {
        webSocket = new WebSocket(url);
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