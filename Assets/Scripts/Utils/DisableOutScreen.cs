using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOutScreen : MonoBehaviour
{
    [SerializeField] Behaviour component = null;

    private void OnBecameVisible()
    {
        component.enabled = true;
    }

    private void OnBecameInvisible()
    {
        component.enabled = false;
    }
}
