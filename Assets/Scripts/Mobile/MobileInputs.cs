using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using SimpleInputNamespace;

public class MobileInputs : MonoBehaviour
{
    public class ButtonEvent : UnityEvent<bool> { };

    [SerializeField] private Joystick stick = null;

    public ButtonEvent onInteraction = new ButtonEvent();
    public ButtonEvent onAttack = new ButtonEvent();

    public Vector2 GetStickValue() => stick.Value.Get4Direction();

    private void Awake()
    {
        if (!GameManager.instance.isPhonePlay)
            gameObject.SetActive(false);
    }

    public void InteractDown()
    {
        onInteraction.Invoke(true);
    }

    public void AttackDown()
    {
        onAttack.Invoke(true);
    }

    public void AttackUp()
    {
        onAttack.Invoke(false);
    }
}
