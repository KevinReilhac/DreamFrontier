using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using UnityEngine.Experimental.Rendering.Universal;

public class Door : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer = null;
    [SerializeField] private Sprite openSprite = null;
    [SerializeField] private Sprite closeSprite = null;
    [OnValueChanged("SetState")] [Tooltip("true -> open, false -> close")]
    [SerializeField] private bool defaultState = false;
    [SerializeField] private ShadowCaster2D shadowCaster = null;

    private bool _state = false;
    private Collider2D _doorCollider = null;

    private void Awake()
    {
        _doorCollider = GetComponent<Collider2D>();
        shadowCaster = GetComponent<ShadowCaster2D>();
        State = defaultState;
    }

    public void Toggle()
    {
        State = !State;
    }

    public void SetState()
    {
        State = defaultState;
    }

    public bool State
    {
        get
        {
            return _state;
        }
        set
        {
            if (_doorCollider)
                _doorCollider.enabled = !value;
            if (spriteRenderer)
                spriteRenderer.sprite = value ? openSprite : closeSprite;
            if (shadowCaster)
                shadowCaster.enabled = !value;
            _state = value;
        }
    }
}
