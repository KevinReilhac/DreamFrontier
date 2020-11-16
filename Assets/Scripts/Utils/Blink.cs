using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blink : MonoBehaviour
{
    [SerializeField] private GameObject target = null;
    [SerializeField] private float blinkTime = 1f;

    private void Start()
    {
        StartCoroutine(BlinkCoroutine());
    }

    private IEnumerator BlinkCoroutine()
    {
        while (enabled)
        {
            target.SetActive(!target.activeSelf);
            yield return new WaitForSeconds(blinkTime);
        }
    }
}
