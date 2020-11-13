using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private UnityEvent OnInteract = null;

    private bool _isHighlight = false;

    public void Interact()
    {
        if (OnInteract != null)
            OnInteract.Invoke();
    }

    public bool IsHighlight()
    {
        return (_isHighlight);
    }

    public void StartHighlight()
    {
        throw new System.NotImplementedException();
    }

    public void StopHighlight()
    {
        throw new System.NotImplementedException();
    }
}
