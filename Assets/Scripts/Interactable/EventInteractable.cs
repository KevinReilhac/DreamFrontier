using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private UnityEvent OnInteract = null;

    private Renderer _renderer = null;
    private bool _isHighlight = false;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        StopHighlight();
    }

    public void Interact()
    {
        if (OnInteract != null)
            OnInteract.Invoke();
        StopHighlight();
    }

    public bool IsHighlight()
    {
        return (_isHighlight);
    }

    public void StartHighlight()
    {
        _renderer.material.SetFloat("_opacity", 1f);
    }

    public void StopHighlight()
    {
        _renderer.material.SetFloat("_opacity", 0f);
    }
}
