using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainLoading : MonoBehaviour
{
    public Scrollbar loadingBar;

    void Start()
    {
        StartCoroutine(LoadAsyncOperation(1));
    }

    IEnumerator LoadAsyncOperation(int id)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(id);
        
        while (!operation.isDone)
        {
            Debug.Log(operation.progress);
            loadingBar.size = operation.progress;
            yield return null;
        }
    }
}