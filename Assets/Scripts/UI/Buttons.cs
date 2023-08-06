using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Buttons : MonoBehaviour
{
    public GameObject exitButton;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void ClickExit()
    {
        Application.Quit();
    }
}
