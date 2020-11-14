using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CameraShake;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Transform target = null;
    [SerializeField] private float shakeTime = 0.5f;

    private void Start()
    {
        if (target == null)
            target = GameObject.FindObjectOfType<Player>()?.transform;
    }

    private void Update()
    {
        UpdateCameraPosition();
    }

    private void UpdateCameraPosition()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }

    public void Shake()
    {
        StartCoroutine(ShakeCoroutine());
    }

    private IEnumerator ShakeCoroutine()
    {
        enabled = false;
        CameraShaker.Presets.Explosion2D(duration: shakeTime);
        yield return new WaitForSeconds(shakeTime);
        enabled = true;
    }
}
