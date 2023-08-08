using UnityEngine;
using WebSocketSharp;

public class WebSocketManager : MonoBehaviour
{
    private static WebSocketManager instance;
    private WebSocket webSocket;

    public static WebSocketManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject); // Jeśli chcesz, aby obiekt przetrwał między scenami

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
            Debug.Log("WS: " + e.Data);
        };
    }

    public void SendWebSocketMessage(string message)
    {
        if (webSocket.ReadyState == WebSocketState.Open)
        {
            webSocket.Send(message);
        }
    }
}