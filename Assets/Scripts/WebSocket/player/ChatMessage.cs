using TMPro;
using UnityEngine;

public class ChatMessage : MonoBehaviour
{
    public TMP_Text lol;

    public void takeMessage(string text)
    {
        lol.SetText(text);
    }
}