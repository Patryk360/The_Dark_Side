using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    public Canvas menu;
    public Canvas mapLoading;
    public TMP_Dropdown maps;
    public AudioListener audioListener;
    public Scrollbar mapLoadingScrollbar;
    public Button singleplayer;

    void Start()
    {
        AudioListener.pause = false;
    }

    public void StartButton()
    {
        audioListener.enabled = false;
        menu.enabled = false;
        singleplayer.enabled = false;
        mapLoading.enabled = true;
        StartCoroutine(LoadAsyncScene(maps.value + 2));
    }

    IEnumerator LoadAsyncScene(int id)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        
        while (!operation.isDone)
        {
            yield return null;
        }

        StartCoroutine(LoadAsyncMap());

        IEnumerator LoadAsyncMap()
        {
            AsyncOperation operation2 = SceneManager.LoadSceneAsync(id, LoadSceneMode.Additive);

            while (!operation2.isDone)
            {
                mapLoadingScrollbar.size = operation2.progress;
                yield return null;
            }
            mapLoading.enabled = false;
        }
    }
}