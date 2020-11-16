using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteractable : EventInteractable
{
    [Header("Button")]
    [SerializeField] private SpriteRenderer spriteRenderer = null;
    [SerializeField] private Sprite pressedSprite = null;
    [SerializeField] private GameObject buttonLight = null;
    [SerializeField] private float pressedTime = 0.3f;

    private Sprite _defaultSprite = null;

    private void Awake()
    {
        _defaultSprite = spriteRenderer.sprite;
    }

    public override void Interact()
    {
        if (!_canUse)
            return;
        base.Interact();
        StartCoroutine(InteractCoroutine());
    }

    private IEnumerator InteractCoroutine()
    {
        _canUse = false;
        spriteRenderer.sprite = pressedSprite;
        buttonLight.SetActive(false);
        yield return new WaitForSeconds(pressedTime);
        buttonLight.SetActive(true);
        spriteRenderer.sprite = _defaultSprite;
        _canUse = true;
    }
}
