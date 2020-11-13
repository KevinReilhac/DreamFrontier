using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    void Interact();
    void StartHighlight();
    void StopHighlight();
    bool IsHighlight();
}
