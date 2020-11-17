using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TitleScreen : MonoBehaviour
{
    [SerializeField] private Image pressStart = null;

    void Start()
    {
        GameManager.instance.Init();
        GameManager.instance.DeathCount = 0;
        SetupInput();
        SetupPressStartAnim();
    }

    private void SetupPressStartAnim()
    {
        LeanTween.alpha(pressStart.GetComponent<RectTransform>(), 0f, 2f).setLoopPingPong().setEase(LeanTweenType.easeInOutQuart);
    }

    private void SetupInput()
    {
        GameManager.instance.Controls.MainGameplay.Interact.performed += Load;
    }

    private void Load(InputAction.CallbackContext context)
    {
        GameManager.instance.Controls.MainGameplay.Interact.performed -= Load;
        GameManager.instance.GetSceneManager().LoadNextScene();
    }
}
