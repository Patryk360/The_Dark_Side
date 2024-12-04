using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIButtons : MonoBehaviour
{
    public Canvas button;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (button.enabled)
            {
                button.enabled = false;
            } else
            {
                button.enabled = true;
            }
        }
    }
    public void BackMenu()
    {
        Time.timeScale = 1;

        StartCoroutine(LoadMenuAsync());

        IEnumerator LoadMenuAsync()
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(0, LoadSceneMode.Single);

            while (!operation.isDone)
            {
                yield return null;
            }
        }
    }
}