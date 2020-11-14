using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private UnityEvent OnInteract = null;

    private Renderer _renderer = null;
    private bool _isHighlight = false;
    private bool _hasBeenUsed = false;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        StopHighlight();
    }

    public void Interact()
    {
        if (_hasBeenUsed)
            return;
        if (OnInteract != null)
            OnInteract.Invoke();
        _hasBeenUsed = true;
        StopHighlight();
    }

    public bool IsHighlight()
    {
        return (_isHighlight);
    }

    public void StartHighlight()
    {
        if (_hasBeenUsed)
            return;
        _renderer.material.SetFloat("_opacity", 1f);
    }

    public void StopHighlight()
    {
        _renderer.material.SetFloat("_opacity", 0f);
    }

    public bool HasBeenUsed
    {
        get => _hasBeenUsed;
    }
}
