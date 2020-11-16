using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomScenesManager : Manager<CustomScenesManager>
{
    [SerializeField] private RectTransform fadeImage = null;
    [SerializeField] private float fadeTime = 1f;

    private bool isInTransition = false;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        if (!isInTransition)
            OutTransition();
    }

    public void ReloadScene()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadNextScene()
    {
        LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneCoroutine(sceneId));
    }

    private IEnumerator LoadSceneCoroutine(int sceneId)
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.


        InTransition();
        while (isInTransition)
            yield return null;
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneId);
        while (!asyncLoad.isDone)
            yield return null;
        OutTransition();
    }

    private void InTransition()
    {
        isInTransition = true;
        LeanTween.alpha(fadeImage, 1f, fadeTime).setOnComplete(() => isInTransition = false);
    }

    private void OutTransition()
    {
        LeanTween.alpha(fadeImage, 0f, fadeTime);
    }

}
