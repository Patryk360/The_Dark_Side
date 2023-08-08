using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Canvas menu;
    void Start()
    {
        menu.enabled = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menu.enabled == false)
            {
                menu.enabled = true;
                Time.timeScale = menu.enabled ? 0 : 1;
                AudioListener.pause = !AudioListener.pause;
                AudioListener.pause = AudioListener.pause ? true : false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                menu.enabled = false;
                Time.timeScale = menu.enabled ? 0 : 1;
                AudioListener.pause = !AudioListener.pause;
                AudioListener.pause = AudioListener.pause ? true : false;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
