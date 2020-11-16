using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private UnityEvent OnInteract = null;

    private Renderer _renderer = null;
    private bool _isHighlight = false;
    protected bool _canUse = true;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        StopHighlight();
    }

    virtual public void Interact()
    {
        if (!_canUse)
            return;
        if (OnInteract != null)
            OnInteract.Invoke();
        StopHighlight();
    }

    public bool IsHighlight()
    {
        return (_isHighlight);
    }

    public virtual void StartHighlight()
    {
        _renderer?.material.SetFloat("_opacity", 1f);
    }

    public virtual void StopHighlight()
    {
        _renderer?.material.SetFloat("_opacity", 0f);
    }
}
