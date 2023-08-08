using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RealtimeChat : MonoBehaviour
{
    public Canvas chat;
    public TMP_InputField chatText;
    void Start()
    {
        chat.enabled = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            chat.enabled = true;
            
            if (chat.enabled)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            } else {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        if (chat.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (chatText.text != "")
                {
                    WebSocketManager.Instance.SendWebSocketMessage(chatText.text);
                    chatText.text = "";
                    chat.enabled = false;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
            }
        }
    }
}
