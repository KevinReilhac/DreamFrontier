using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomScenesManager : MonoBehaviour
{
    [SerializeField] private RectTransform fadeImage = null;
    [SerializeField] private float fadeTime = 1f;

    private bool isInTransition = false;
    private bool isLoad = false;

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
        if (isLoad)
            return;
        StartCoroutine(LoadSceneCoroutine(sceneId));
    }

    private IEnumerator LoadSceneCoroutine(int sceneId)
    {
        isLoad = true;
        InTransition();
        while (isInTransition)
            yield return null;
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneId);
        while (!asyncLoad.isDone)
            yield return null;
        OutTransition();
        isLoad = true;
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
