using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Image imageRenderer = null;
    [SerializeField] private List<Sprite> states = null;

    [SerializeField] private Image controllsRenderer = null;

    private int _stateIndex = 0;
    private bool _isShowControls = false;

    private void Awake()
    {
        gameObject.SetActive(false);
        SetupInputs();
    }

    private void SetupInputs()
    {
        PlayerControls inputs = GameManager.instance.Controls;

        inputs.PauseMenu.Navigate.started += Navigate;
        inputs.PauseMenu.Cancel.started += Cancel;
        inputs.PauseMenu.Validate.started += Validate;
    }

    private void OnDestroy()
    {
        PlayerControls inputs = GameManager.instance.Controls;

        if (inputs == null)
            return;

        inputs.PauseMenu.Navigate.started -= Navigate;
        inputs.PauseMenu.Cancel.started -= Cancel;
        inputs.PauseMenu.Validate.started -= Validate;
    }

    private void UpdateImage()
    {
        imageRenderer.sprite = states[_stateIndex];
    }

    private void Navigate(InputAction.CallbackContext context)
    {
        float axisValue = context.ReadValue<float>();

        _stateIndex += Mathf.RoundToInt(axisValue);
        if (_stateIndex == -1)
            _stateIndex = states.Count - 1;
        if (_stateIndex == states.Count)
            _stateIndex = 0;

        UpdateImage();
    }

    public void Pause()
    {
        _stateIndex = 0;
        UpdateImage();
        gameObject.SetActive(true);
        GameManager.instance.Controls.PauseMenu.Enable();
        GameManager.instance.Controls.MainGameplay.Disable();
        Time.timeScale = 0f;
    }

    private void Cancel(InputAction.CallbackContext context)
    {
        if (_isShowControls)
            HideControls();
        else
            Continue();
    }

    public void Continue()
    {
        gameObject.SetActive(false);
        GameManager.instance.Controls.PauseMenu.Disable();
        GameManager.instance.Controls.MainGameplay.Enable();
        Time.timeScale = 1f;
    }

    private void ShowControls()
    {
        controllsRenderer.gameObject.SetActive(true);
        _isShowControls = true;
    }

    private void HideControls()
    {
        controllsRenderer.gameObject.SetActive(false);
        _isShowControls = false;
    }

    private void ReturnToTitle()
    {
        Time.timeScale = 1;
        GameManager.instance.DeathCount = 0;
        GameManager.instance.GetSceneManager().LoadScene(0);
        Continue();
        GameManager.instance.Controls.PauseMenu.Disable();
        GameManager.instance.Controls.MainGameplay.Enable();
    }

    private void Validate(InputAction.CallbackContext context)
    {
        if (_isShowControls)
        {
            HideControls();
            return;
        }

        switch (_stateIndex)
        {
            default:
            case 0:
                Continue();
                break;
            case 1:
                ShowControls();
                break;
            case 2:
                ReturnToTitle();
                break;
        }
    }
}
