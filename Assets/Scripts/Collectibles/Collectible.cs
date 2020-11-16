using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ACollectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollect();
            Destroy(gameObject);
        }
    }

    protected abstract void OnCollect();
}
