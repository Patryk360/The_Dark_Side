using TMPro;
using UnityEngine;
using Newtonsoft.Json;

public class ChatData
{
    public string Type { get; set; }
    public string Content { get; set; }
}
public class RealtimeChat : MonoBehaviour
{
    public Canvas chat;
    public TMP_InputField chatText;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            chat.enabled = true;
            
            if (chat.enabled)
            {
                chatText.ActivateInputField();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            } else {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

        if (!chat.enabled)
        {
            return;
        }

        if (!Input.GetKeyDown(KeyCode.Return))
        {
            return;
        }

        if (chatText.text == "")
        {
            return;
        }
        
        ChatData chatData = new ChatData
        {
            Type = "chat",
            Content = chatText.text
        };
        string json = JsonConvert.SerializeObject(chatData);
        WebSocketManager.SendWebSocketMessage(json);
        
        chatText.text = "";
        chat.enabled = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
