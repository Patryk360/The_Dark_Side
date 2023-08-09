using TMPro;
using UnityEngine;

public class ChangeNick : MonoBehaviour
{
    public TMP_InputField nickInputField;
    public TMP_Text playerNickText;
    public TMP_Text actualNickText;
    void Start()
    {
        nickInputField.text = actualNickText.text;
    }
    void Update()
    {
        
    }
    public void ChangeNickButton()
    {
        playerNickText.text = nickInputField.text;
        actualNickText.text = nickInputField.text;
    }
}
