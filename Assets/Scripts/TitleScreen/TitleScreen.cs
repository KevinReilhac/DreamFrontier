using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class TitleScreen : MonoBehaviour
{
    [SerializeField] private Image pressStart = null;
    private PlayerControls _inputs;

    void Start()
    {
        SetupInput();
        SetupPressStartAnim();
    }

    private void SetupPressStartAnim()
    {
        LeanTween.alpha(pressStart.GetComponent<RectTransform>(), 0f, 2f).setLoopPingPong().setEase(LeanTweenType.easeInOutQuart);
    }

    private void SetupInput()
    {
        _inputs = new PlayerControls();
        _inputs.Enable();

        _inputs.MainGameplay.Interact.performed += Load;
    }

    private void Load(InputAction.CallbackContext context)
    {
        _inputs.MainGameplay.Interact.performed -= Load;
        CustomScenesManager.instance.LoadNextScene();
    }
}
