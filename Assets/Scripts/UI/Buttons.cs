using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject exitButton;
    public void ClickExit()
    {
        Application.Quit();
    }
}
