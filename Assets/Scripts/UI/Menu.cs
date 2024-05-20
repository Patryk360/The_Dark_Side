using UnityEngine;

public class Menu : MonoBehaviour
{
    public Canvas menu;
    public GameObject exit;
    void Start()
    {
        #if UNITY_STANDALONE
        exit.SetActive(true);
        #else
        exit.SetActive(false);
        #endif
        menu.enabled = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menu.enabled == false)
            {
                menu.enabled = true;
                if (!WebSocketManager.IsConneted())
                {
                    Time.timeScale = 0;
                }
                AudioListener.pause = !AudioListener.pause;
                AudioListener.pause = AudioListener.pause ? true : false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                menu.enabled = false;
                if (!WebSocketManager.IsConneted())
                {
                    Time.timeScale = 1;
                }
                AudioListener.pause = !AudioListener.pause;
                AudioListener.pause = AudioListener.pause ? true : false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
